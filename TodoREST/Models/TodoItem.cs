using System;

namespace TodoREST
{
	public class TodoItem
	{
        public string resultCode { get; set; }          //응답결과코드
		public string resultMsg { get; set; }           //응답결과메시지
		public string numOfRows { get; set; }           //한페이지결과수
        public string pageNo { get; set; }              //현재페이지번호
		public string totalCount { get; set; }          //전체결과수
		public string addr1 { get; set; }               //주소(예, 서울중랑구다동)를 응답
		public string addr2 { get; set; }               //상세주소
		public string areacode { get; set; }            //지역코드
		public string booktour { get; set; }            //교과서여행지여부(1=여행지,0=해당없음)
        public string cat1 { get; set; }                //대분류코드
		public string cat2 { get; set; }                //중분류코드
		public string cat3 { get; set; }                //소분류코드
		public string contenid { get; set; }            //콘텐츠ID
		public string contenTyprId { get; set; }        //관광타입(관광지,숙박등)ID
		public string createdtime { get; set; }         //콘텐츠최초등록일
		public string firstimage { get; set; }          //원본대표이미지(약500*333 size) URL 응답
		public string firstimage2 { get; set; }         //원본썸네일이미지(약500*333 size) URL 응답
		public string mapX { get; set; }                //GPS X좌표(WGS84 경도좌표) 응답
		public string mapY { get; set; }                //GPS Y좌표(WGS84 위도좌표) 응답
		public string mlevel { get; set; }              //Map Level 응답
		public string modifiedtime { get; set; }        //컨텐츠수정일
		public string readcount { get; set; }           //콘텐츠조회수(korean.visitkorea.or.kr 웹사이트기준)
		public string sigungucode { get; set; }         //시군구코드
		public string tel { get; set; }                 //전화번호
		public string title { get; set; }               //콘텐츠 제목
		public string zipcode { get; set; }             //우편번호
		public string telname { get; set; }             //전화번호명
		public string eventstartdate { get; set; }      //행사시작일(형식:YYYYMMDD)
		public string eventenddate { get; set; }        //행사종료일(형식:YYYYMMDD)

	}
}
