import mongoose from "mongoose";


const InvoiceSchema = new mongoose.Schema({
        amount: Number
});

export const Invoice = mongoose.model('Invoice', InvoiceSchema);