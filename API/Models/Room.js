import mongoose from 'mongoose';

const roomSchema = new mongoose.Schema({
      roomNumber: Number,
      style: Number, // 0: Standard, 1: Deluxe, 2: Family, 3: Business
      status: Number, // 0: Available, 1: NotAvailable
      bookingPrice: Number,
      isSmoking: Boolean,
});

export const Room = mongoose.model('Room', roomSchema);
