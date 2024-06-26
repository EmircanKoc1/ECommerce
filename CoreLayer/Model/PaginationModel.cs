﻿using CoreLayer.Constants.ModelConstants;

namespace CoreLayer.Model
{
    public class PaginationModel
    {
        public int PageSize
        {
            get => pageSize;
            set => pageSize = value >= PaginationConstants.MAX_PAGE_SIZE ? PaginationConstants.MAX_PAGE_SIZE : (value <= 0 ? 1 : value);
        }
        public int PageNumber
        {
            get => pageNumber;
            set => pageNumber = value <= 0 ? 1 : value;
        }


        private int pageSize = 1;
        private int pageNumber = 1;
    }
}
