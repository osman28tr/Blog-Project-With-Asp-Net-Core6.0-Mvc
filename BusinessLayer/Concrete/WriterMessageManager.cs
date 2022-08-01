using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;
        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetReceiverMessageList(string receiverEmail)
        {
            return _writerMessageDal.GetByFilter(x => x.Receiver == receiverEmail);
        }

        public List<WriterMessage> GetSenderMessageList(string senderEmail)
        {
            return _writerMessageDal.GetByFilter(x => x.Sender == senderEmail);
        }

        public void TAdd(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
