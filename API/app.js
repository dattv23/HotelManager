import express, { response } from 'express';
import bodyParser from 'body-parser';
import mongoose from 'mongoose';
import { User } from './Models/User.js';
import { Room } from './Models/Room.js';
import { RoomBooking } from './Models/RoomBooking.js';
import { Notification } from './Models/Notification.js';
import { BillTransaction } from './Models/BillTransaction.js';
import { Invoice } from './Models/Invoice.js';

const app = express();

app.use(bodyParser.json());

// Tạo kết nối với db
mongoose.connect('mongodb+srv://datvan635:vandat23032003@qlks.8j3kehb.mongodb.net/QLKS', { useNewUrlParser: true, useUnifiedTopology: true })
      .then(() => console.log('Database Connected!'))
      .catch((err) => console.error(err));

app.route("/")
      .get((req, res) => res.send("Hello"));

app.route("/users")
      .get(async function (req, res) {
            try {
                  const users = await User.find();
                  res.json(users);
            } catch (err) {
                  console.log('====================================');
                  console.log(err);
                  console.log('====================================');
            }
      })
      .post(async function (req, res) {
            try {
                  // Lấy thông tin của người dùng
                  const { name, phone, email, address, accountType, account } = req.body;

                  // Kiểm tra xem người dùng đã tồn tại hay chưa
                  const existingUser = await User.findOne({ phone });

                  if (existingUser) {
                        // Trả về lỗi 409 nếu người dùng đã tồn tại
                        return res.status(409).json({ error: 'Người dùng đã tồn tại.' });
                  }
                  const newUser = new User({
                        name,
                        phone,
                        email,
                        address,
                        accountType,
                        account
                  });
                  const savedUser = await newUser.save();
                  res.status(200).json(savedUser);
            } catch (err) {
                  console.log('====================================');
                  console.log(err);
                  console.log('====================================');
            }
      })
      .put(async function (req, res) {
            try {
                  // Lấy thông tin của người dùng cần cập nhật
                  const { name, phone, email, address, accountType, account } = req.body;

                  // Tìm người dùng theo name (hoặc một trường duy nhất để xác định người dùng cần cập nhật)
                  const userToUpdate = await User.findOne({ phone });

                  // Kiểm tra xem người dùng có tồn tại không
                  if (!userToUpdate) {
                        return res.status(404).json({ error: 'Không tìm thấy người dùng.' });
                  }

                  // Cập nhật thông tin người dùng
                  userToUpdate.name = name;
                  userToUpdate.phone = phone;
                  userToUpdate.email = email;
                  userToUpdate.address = address;
                  userToUpdate.accountType = accountType;
                  userToUpdate.account = account;

                  // Lưu thông tin người dùng đã cập nhật vào cơ sở dữ liệu
                  const updatedUser = await userToUpdate.save();

                  res.status(200).json(updatedUser);
            } catch (err) {
                  console.log('====================================');
                  console.error(err);
                  console.log('====================================');
                  res.status(500).json({ error: 'Lỗi khi cập nhật người dùng.' });
            }
      })
      .delete(async function (req, res) {
            try {
                  // Lấy thông tin của người dùng cần xóa
                  const { phone } = req.query;

                  // Tìm người dùng theo phone (hoặc một trường duy nhất để xác định người dùng cần xóa)
                  const userToDelete = await User.findOne({ phone });

                  // Kiểm tra xem người dùng có tồn tại không
                  if (!userToDelete) {
                        return res.status(404).json({ error: 'Không tìm thấy người dùng.' });
                  }

                  // Xóa người dùng khỏi cơ sở dữ liệu
                  await userToDelete.deleteOne();

                  res.status(200).json({ message: 'Người dùng đã được xóa thành công.' });
            } catch (err) {
                  console.log('====================================');
                  console.error(err);
                  console.log('====================================');
                  res.status(500).json({ error: 'Lỗi khi xóa người dùng.' });
            }
      });
app.route('/getUserByPhone/:PhoneNumber')
      .get(async (req, res) => {
            try {
                  const PhoneNumber = req.params.PhoneNumber;
                  const user = await User.find({ phone: PhoneNumber });
                  if (!user) {
                        return res.status(404).json({ error: 'User not found' });
                  }
                  res.status(200).json(user);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving user' });
            }
      })
      .put(async (req, res) => {
            try {
                  const PhoneNumber = req.params.PhoneNumber;
                  const {
                        name,
                        email,
                        address,
                        accountType,
                        phone: newPhoneNumber, // Include phone in the update
                  } = req.body;

                  const userToUpdate = await User.findOneAndUpdate(
                        { phone: PhoneNumber },
                        {
                              name,
                              email,
                              address,
                              accountType,
                              phone: newPhoneNumber, // Update phone
                        },
                        { new: true }
                  );

                  if (!userToUpdate) {
                        return res.status(404).json({ error: 'User not found' });
                  }

                  res.status(200).json(userToUpdate);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error updating user' });
            }
      })
      .delete(async (req, res) => {
            try {
                  const PhoneNumber = req.params.PhoneNumber;
                  const userToDelete = await User.findOneAndDelete({ phone: PhoneNumber });
                  if (!userToDelete) {
                        return res.status(404).json({ error: 'User not found' });
                  }
                  res.status(204).send();
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error deleting user' });
            }
      });

app.route("/findAccount")
      .post(async (req, res) => {
            try {
                  const { phone, username } = req.body;

                  const account = await User.findOne({ phone: phone, "account.username": username });
                  if (!account) {
                        res.status(404).json({ error: 'Không tìm thấy tài khoản.' })
                  } else {
                        res.status(200).json({ message: 'Tài khoản có trong database!' })
                  }

            } catch (error) {

            }
      })

app.route("/rooms")
      .get(async function (req, res) {
            try {
                  const rooms = await Room.find();
                  res.status(200).json(rooms);
            } catch (error) {
                  console.log('====================================');
                  console.log(error);
                  console.log('====================================');
                  res.status(404).json({ error: 'Lỗi truy xuất phòng!' });
            }
      })
      .post(async function (req, res) {
            try {
                  // Lấy thông tin của phòng
                  const { roomNumber, style, status, bookingPrice, isSmoking } = req.body;

                  // Kiểm tra xem phòng đã tồn tại hay chưa
                  const existingRoom = await Room.findOne({ roomNumber });
                  if (existingRoom) {
                        // Trả về lỗi 409 nếu người dùng đã tồn tại
                        return res.status(409).json({ error: 'Room existed.' });
                  }

                  // Lưu phòng
                  const newRoom = new Room({
                        roomNumber, style, status, bookingPrice, isSmoking
                  });
                  const savedRoom = await newRoom.save();
                  res.status(200).json(savedRoom);
            } catch (err) {
                  console.log('====================================');
                  console.log(err);
                  console.log('====================================');
            }
      })
      .put(async function (req, res) {
            try {
                  // Lấy thông tin của phòng
                  const { roomNumber, style, status, bookingPrice, isSmoking } = req.body;

                  // Kiểm tra xem có phòng không
                  const roomToUpdate = await Room.findOne({ roomNumber });
                  if (!roomToUpdate) {
                        return res.status(404).json({ error: 'Room not found.' });
                  }

                  // Cập nhật thông tin phòng
                  roomToUpdate.roomNumber = roomNumber;
                  roomToUpdate.style = style;
                  roomToUpdate.status = status;
                  roomToUpdate.bookingPrice = bookingPrice;
                  roomToUpdate.isSmoking = isSmoking;

                  // Lưu thông tin phòng và cập nhật vào cơ sở dữ liệu
                  const updatedRoom = await roomToUpdate.save();

                  res.status(200).json(updatedRoom);
            } catch (err) {
                  console.log('====================================');
                  console.error(err);
                  console.log('====================================');
                  res.status(500).json({ error: 'Error updating room.' });
            }
      })
      .delete(async function (req, res) {
            try {
                  // Lấy thông tin của phòng cần xóa
                  const { roomNumber } = req.body;

                  // Tìm phòng theo roomNumber (hoặc một trường duy nhất để xác định phòng cần xóa)
                  const roomToDelete = await Room.findOne({ roomNumber });

                  // Kiểm tra xem phòng có tồn tại không
                  if (!roomToDelete) {
                        return res.status(404).json({ error: 'Room not found.' });
                  }

                  // Xóa phòng khỏi cơ sở dữ liệu
                  await roomToDelete.deleteOne();

                  res.status(200).json({ message: 'Delete room successed.' });
            } catch (err) {
                  console.log('====================================');
                  console.error(err);
                  console.log('====================================');
                  res.status(500).json({ error: 'Error deleting room.' });
            }
      })

app.route('/rooms/:roomNumber')
      .get(async function (req, res) {
            try {
                  const { roomNumber } = req.params;
                  const room = await Room.findOne({ roomNumber });
                  if (!room) {
                        res.status(404).json({ error: `Not found room with RoomNumber ${roomNumber}.` })
                  } else {
                        res.status(200).json(room);
                  }
            } catch (error) {
                  console.log('====================================');
                  console.log(error);
                  console.log('====================================');
                  res.status(500).json({ error: 'Error retrieving room information!' });
            }
      })
      .delete(async (req, res) => {
            try {
                  const { roomNumber } = req.params;
                  const roomToDelete = await Room.findOneAndDelete({ roomNumber: parseInt(roomNumber) });
                  if (!roomToDelete) {
                        return res.status(404).json({ error: 'Room not found!' });
                  } else {
                        return res.status(200).json({ message: 'Room delete successfully!' });
                  }
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error deleting room!' });
            }
      });

app.route('/bookings')
      .get(async (req, res) => {
            try {
                  const bookings = await RoomBooking.find();
                  res.status(200).json(bookings);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving bookings' });
            }
      })
      .post(async (req, res) => {
            try {
                  const {
                        reservationNumber,
                        startDate,
                        checkin,
                        checkout,
                        roomNumber,
                        style,
                        phoneNumber,
                  } = req.body;

                  const newBooking = new RoomBooking({
                        reservationNumber,
                        startDate,
                        checkin,
                        checkout,
                        roomNumber,
                        style,
                        phoneNumber,
                  });

                  const savedBooking = await newBooking.save();
                  res.status(201).json(savedBooking);
            } catch (err) {
                  console.error(err);
                  res.status(400).json({ error: 'Error creating booking' });
            }
      });

app.route('/bookings/:PhoneNumber')
      .get(async (req, res) => {
            try {
                  const PhoneNumber = req.params.PhoneNumber;
                  const booking = await RoomBooking.find({ phoneNumber: PhoneNumber });
                  if (!booking) {
                        return res.status(404).json({ error: 'Booking not found' });
                  }
                  res.status(200).json(booking);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving booking' });
            }
      })
      .put(async (req, res) => {
            try {
                  const PhoneNumber = req.params.PhoneNumber;
                  const {
                        reservationNumber,
                        startDate,
                        checkin,
                        checkout,
                        roomNumber,
                        style,
                        phoneNumber: newPhoneNumber,// Include phoneNumber in the update
                  } = req.body;

                  const bookingToUpdate = await RoomBooking.findOneAndUpdate(
                        { phoneNumber: PhoneNumber },
                        {
                              reservationNumber,
                              startDate,
                              checkin,
                              checkout,
                              roomNumber,
                              style,
                              phoneNumber: newPhoneNumber, // Update phoneNumber
                        },
                        { new: true }
                  );

                  if (!bookingToUpdate) {
                        return res.status(404).json({ error: 'Booking not found' });
                  }

                  res.status(200).json(bookingToUpdate);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error updating booking' });
            }
      })
      .delete(async (req, res) => {
            try {
                  const PhoneNumber = req.params.PhoneNumber;
                  const bookingToDelete = await RoomBooking.findOneAndDelete({ phoneNumber: PhoneNumber });
                  if (!bookingToDelete) {
                        return res.status(404).json({ error: 'Booking not found' });
                  }
                  res.status(204).send();
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error deleting booking' });
            }
      });


app.route('/notifications')
      .get(async (req, res) => {
            try {
                  const notifications = await Notification.find();
                  res.status(200).json(notifications);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving notifications' });
            }
      })
      .post(async (req, res) => {
            try {
                  const { notificationId, createdOn, content } = req.body;

                  const newNotification = new Notification({
                        notificationId,
                        createdOn,
                        content,
                  });

                  const savedNotification = await newNotification.save();
                  res.status(201).json(savedNotification);
            } catch (err) {
                  console.error(err);
                  res.status(400).json({ error: 'Error creating notification' });
            }
      });

app.route('/notifications/:notificationId')
      .get(async (req, res) => {
            try {
                  const notification = await Notification.findById(req.params.notificationId);
                  if (!notification) {
                        return res.status(404).json({ error: 'Notification not found' });
                  }
                  res.status(200).json(notification);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving notification' });
            }
      })
      .put(async (req, res) => {
            try {
                  const { notificationId, createdOn, content } = req.body;

                  const notificationToUpdate = await Notification.findByIdAndUpdate(
                        req.params.notificationId,
                        {
                              notificationId,
                              createdOn,
                              content,
                        },
                        { new: true }
                  );

                  if (!notificationToUpdate) {
                        return res.status(404).json({ error: 'Notification not found' });
                  }

                  res.status(200).json(notificationToUpdate);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error updating notification' });
            }
      })
      .delete(async (req, res) => {
            try {
                  const notificationToDelete = await Notification.findByIdAndDelete(req.params.notificationId);
                  if (!notificationToDelete) {
                        return res.status(404).json({ error: 'Notification not found' });
                  }
                  res.status(204).send();
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error deleting notification' });
            }
      });


app.route('/billtransactions')
      .get(async (req, res) => {
            try {
                  const billTransactions = await BillTransaction.find();
                  res.status(200).json(billTransactions);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving bill transactions' });
            }
      })
      .post(async (req, res) => {
            try {
                  const { creationDate, amount, status, method, reservationNumber } = req.body;

                  const newBillTransaction = new BillTransaction({
                        creationDate,
                        amount,
                        status,
                        method,
                        reservationNumber
                  });

                  const savedBillTransaction = await newBillTransaction.save();
                  res.status(201).json(savedBillTransaction);
            } catch (err) {
                  console.error(err);
                  res.status(400).json({ error: 'Error creating bill transaction' });
            }
      });

app.route('/billtransactions/:reservationNumber')
      .get(async (req, res) => {
            try {
                  const billTransaction = await BillTransaction.findById(req.params.id);
                  if (!billTransaction) {
                        return res.status(404).json({ error: 'Bill transaction not found' });
                  }
                  res.status(200).json(billTransaction);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving bill transaction' });
            }
      })
      .put(async (req, res) => {
            try {
                  const { creationDate, amount, status } = req.body;

                  const billTransactionToUpdate = await BillTransaction.findByIdAndUpdate(
                        req.params.id,
                        {
                              creationDate,
                              amount,
                              status,
                              methods,
                        },
                        { new: true }
                  );

                  if (!billTransactionToUpdate) {
                        return res.status(404).json({ error: 'Bill transaction not found' });
                  }

                  res.status(200).json(billTransactionToUpdate);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error updating bill transaction' });
            }
      })
      .delete(async (req, res) => {
            try {
                  const billTransactionToDelete = await BillTransaction.findByIdAndDelete(req.params.id);
                  if (!billTransactionToDelete) {
                        return res.status(404).json({ error: 'Bill transaction not found' });
                  }
                  res.status(204).send();
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error deleting bill transaction' });
            }
      });

app.route('/invoices')
      .get(async (req, res) => {
            try {
                  const invoices = await Invoice.find();
                  res.status(200).json(invoices);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving invoices' });
            }
      })
      .post(async (req, res) => {
            try {
                  const { amount } = req.body;

                  const newInvoice = new Invoice({ amount });

                  const savedInvoice = await newInvoice.save();
                  res.status(201).json(savedInvoice);
            } catch (err) {
                  console.error(err);
                  res.status(400).json({ error: 'Error creating invoice' });
            }
      });

app.route('/invoices/:id')
      .get(async (req, res) => {
            try {
                  const invoice = await Invoice.findById(req.params.id);
                  if (!invoice) {
                        return res.status(404).json({ error: 'Invoice not found' });
                  }
                  res.status(200).json(invoice);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving invoice' });
            }
      })
      .put(async (req, res) => {
            try {
                  const { amount } = req.body;

                  const invoiceToUpdate = await Invoice.findByIdAndUpdate(
                        req.params.id,
                        { amount },
                        { new: true }
                  );

                  if (!invoiceToUpdate) {
                        return res.status(404).json({ error: 'Invoice not found' });
                  }

                  res.status(200).json(invoiceToUpdate);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error updating invoice' });
            }
      })
      .delete(async (req, res) => {
            try {
                  const invoiceToDelete = await Invoice.findByIdAndDelete(req.params.id);
                  if (!invoiceToDelete) {
                        return res.status(404).json({ error: 'Invoice not found' });
                  }
                  res.status(204).send();
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error deleting invoice' });
            }
      });

app.route('/accounts')
      .get(async (req, res) => {
            try {
                  const users = await User.find();
                  const accounts = [];
                  users.forEach(element => {
                        if (element.accountType != 0) {
                              accounts.push(element.account);
                        }
                  });
                  res.status(200).json(accounts);
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving accounts' });
            }
      });

app.route('/resetPassword')
      .post(async (req, res) => {
            try {
                  const { username, phonenumber, newPassword } = req.body;

                  const user = await User.findOne({ phone: phonenumber, "account.username": username });

                  if (!user) {
                        return res.status(404).json({ error: 'Account not found!' });
                  } else {
                        user.account.password = newPassword;
                        await user.save();
                        res.status(200).json({ message: 'Update password successed!' });
                  }
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving accounts' });
            }
      })

app.route('/updateStatusAccount')
      .post(async (req, res) => {
            try {
                  const { username, status } = req.body;

                  const user = await User.findOne({ "account.username": username });

                  if (!user) {
                        return res.status(404).json({ error: 'Account not found!' });
                  } else {
                        user.account.status = status;
                        await user.save();
                        res.status(200).json({ message: 'Update status success!' });
                  }
            } catch (err) {
                  console.error(err);
                  res.status(500).json({ error: 'Error retrieving accounts' });
            }
      })

app.route('/login')
      .post(async (req, res) => {
            try {
                  const { username, password } = req.body;

                  const user = await User.findOne({ "account.username": username, "account.password": password });

                  if (!user) {
                        return res.status(404).json({ error: 'Account not found!' });
                  } else {
                        res.status(200).json({ message: 'Login successful!', accountType: user.accountType });
                  }

            } catch (err) {
                  res.status(500).json({ error: 'Server error' });
            }
      });

app.listen(3000, () => console.log('Server started on port 3000'));