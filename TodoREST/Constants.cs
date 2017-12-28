namespace TodoREST
{
	public static class Constants
	{
        public static int pagenum = 1;
        // URL of REST service
        public static string RestUrl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/searchFestival"
                                       + "?ServiceKey=zUVizBWX1lVLeNXgOlo33%2FHi1qdQyi75SZ92j4aH6Tky7t0UNPV24DKm1haMTpgI%2F5%2FcWcNVIJuCK7OsggfGVA%3D%3D" //서비스 인증
                                       + "&numOfRows=10" //현재 페이지 결과 수
                                       + "&MobileOS=ETC" //모바일 종류
                                       + "&MobileApp=baseApp_1"  //앱이름 
                                       + "&arrange=B" //A=제목순,B=조회순,C=수정순,D=생성일순) 대표이미지 정렬추가 (O=제목순,P=조회순,Q=수정일순,R=생성일순)
                                       + "&eventStartDate=" //행사 시작일
                                       + System.DateTime.Now.ToString("yyyyMMdd")
                                       //+ "20170901" //today  
                                	   + "&pageNo=" //현재 페이지 번호
									   ;
	}
}
