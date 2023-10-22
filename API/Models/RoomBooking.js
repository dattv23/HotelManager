import mongoose from 'mongoose';

const RoomBookingSchema = new   mongoose.Schema({
  reservationNumber: String,
  startDate: Date,
  checkin: Date,
  checkout: Date,
  roomNumber: Number,
  phoneNumber: String,
  style: Number,

});

export const RoomBooking = mongoose.model('RoomBooking', RoomBookingSchema);