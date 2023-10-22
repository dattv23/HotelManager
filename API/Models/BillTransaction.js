import mongoose from 'mongoose';

const BillTransactionSchema = new mongoose.Schema({
      creationDate: Date,
      amount: Number,
      status: Number, // 0. Unpaid, 1.Paid
      method: Number, // 0.CreditCard, 1.CheckTransaction, 2. CashTransaction
      reservationNumber: String
});

export const BillTransaction = mongoose.model('BillTransation', BillTransactionSchema);