﻿using PicBook.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PicBook.Repository.EntityFramework
{
    public interface IPictureRepository
    {
        Task DeletePicture(PictureEntity entity);

        Task<IEnumerable<PictureEntity>> GetAllPicturesByUser(UserEntity entity);

        Task<IEnumerable<PictureEntity>> GetPublicPicturesByUser(UserEntity entity);

        Task<IEnumerable<PictureEntity>> GetAllPublicPictures();

        Task<PictureEntity> GetPictureByUri(Uri uri);

        Task UpdatePicture(PictureEntity entity);

    }
}
