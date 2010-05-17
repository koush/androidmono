namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Browser : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Browser() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Browser), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.Browser(@__env); 
			} 
		} 
		protected Browser(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class BookmarkColumns : java.lang.Object, BaseColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static BookmarkColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Browser.BookmarkColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Browser.BookmarkColumns(@__env); 
				} 
			} 
			protected BookmarkColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _BookmarkColumns5849; 
			public BookmarkColumns()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Browser.BookmarkColumns.staticClass, _BookmarkColumns5849, this); 
			} 
			public static java.lang.String URL
			{ 
				get 
				{ 
					return "url"; 
				} 
			} 
			public static java.lang.String VISITS
			{ 
				get 
				{ 
					return "visits"; 
				} 
			} 
			public static java.lang.String DATE
			{ 
				get 
				{ 
					return "date"; 
				} 
			} 
			public static java.lang.String BOOKMARK
			{ 
				get 
				{ 
					return "bookmark"; 
				} 
			} 
			public static java.lang.String TITLE
			{ 
				get 
				{ 
					return "title"; 
				} 
			} 
			public static java.lang.String CREATED
			{ 
				get 
				{ 
					return "created"; 
				} 
			} 
			public static java.lang.String FAVICON
			{ 
				get 
				{ 
					return "favicon"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Browser.BookmarkColumns.staticClass = @__class; 
				global::android.provider.Browser.BookmarkColumns._BookmarkColumns5849 = @__env.GetMethodID(global::android.provider.Browser.BookmarkColumns.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SearchColumns : java.lang.Object, BaseColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static SearchColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Browser.SearchColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Browser.SearchColumns(@__env); 
				} 
			} 
			protected SearchColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SearchColumns5850; 
			public SearchColumns()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Browser.SearchColumns.staticClass, _SearchColumns5850, this); 
			} 
			public static java.lang.String URL
			{ 
				get 
				{ 
					return "url"; 
				} 
			} 
			public static java.lang.String SEARCH
			{ 
				get 
				{ 
					return "search"; 
				} 
			} 
			public static java.lang.String DATE
			{ 
				get 
				{ 
					return "date"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Browser.SearchColumns.staticClass = @__class; 
				global::android.provider.Browser.SearchColumns._SearchColumns5850 = @__env.GetMethodID(global::android.provider.Browser.SearchColumns.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveBookmark5851; 
		public static void saveBookmark(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _saveBookmark5851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendString5852; 
		public static void sendString(android.content.Context arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _sendString5852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllBookmarks5853; 
		public static android.database.Cursor getAllBookmarks(android.content.ContentResolver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Browser.staticClass, _getAllBookmarks5853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllVisitedUrls5854; 
		public static android.database.Cursor getAllVisitedUrls(android.content.ContentResolver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Browser.staticClass, _getAllVisitedUrls5854, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateVisitedHistory5855; 
		public static void updateVisitedHistory(android.content.ContentResolver arg0, java.lang.String arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _updateVisitedHistory5855, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _truncateHistory5856; 
		public static void truncateHistory(android.content.ContentResolver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _truncateHistory5856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canClearHistory5857; 
		public static bool canClearHistory(android.content.ContentResolver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.provider.Browser.staticClass, _canClearHistory5857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearHistory5858; 
		public static void clearHistory(android.content.ContentResolver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _clearHistory5858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteHistoryTimeFrame5859; 
		public static void deleteHistoryTimeFrame(android.content.ContentResolver arg0, long arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _deleteHistoryTimeFrame5859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteFromHistory5860; 
		public static void deleteFromHistory(android.content.ContentResolver arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _deleteFromHistory5860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSearchUrl5861; 
		public static void addSearchUrl(android.content.ContentResolver arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _addSearchUrl5861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearSearches5862; 
		public static void clearSearches(android.content.ContentResolver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _clearSearches5862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestAllIcons5863; 
		public static void requestAllIcons(android.content.ContentResolver arg0, java.lang.String arg1, android.webkit.WebIconDatabase.IconListener arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, _requestAllIcons5863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Browser5864; 
		public Browser()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.provider.Browser.staticClass, _Browser5864, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _BOOKMARKS_URI5865; 
		public static android.net.Uri BOOKMARKS_URI
		{ 
			get 
			{ 
				return default(android.net.Uri); 
			} 
		} 
		public static java.lang.String INITIAL_ZOOM_LEVEL
		{ 
			get 
			{ 
				return "browser.initialZoomLevel"; 
			} 
		} 
		public static java.lang.String EXTRA_APPLICATION_ID
		{ 
			get 
			{ 
				return "com.android.browser.application_id"; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _HISTORY_PROJECTION5866; 
		public static java.lang.String[] HISTORY_PROJECTION
		{ 
			get 
			{ 
				return default(java.lang.String[]); 
			} 
		} 
		public static int HISTORY_PROJECTION_ID_INDEX
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int HISTORY_PROJECTION_URL_INDEX
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int HISTORY_PROJECTION_VISITS_INDEX
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int HISTORY_PROJECTION_DATE_INDEX
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int HISTORY_PROJECTION_BOOKMARK_INDEX
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int HISTORY_PROJECTION_TITLE_INDEX
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int HISTORY_PROJECTION_FAVICON_INDEX
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TRUNCATE_HISTORY_PROJECTION5867; 
		public static java.lang.String[] TRUNCATE_HISTORY_PROJECTION
		{ 
			get 
			{ 
				return default(java.lang.String[]); 
			} 
		} 
		public static int TRUNCATE_HISTORY_PROJECTION_ID_INDEX
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int TRUNCATE_N_OLDEST
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SEARCHES_URI5868; 
		public static android.net.Uri SEARCHES_URI
		{ 
			get 
			{ 
				return default(android.net.Uri); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SEARCHES_PROJECTION5869; 
		public static java.lang.String[] SEARCHES_PROJECTION
		{ 
			get 
			{ 
				return default(java.lang.String[]); 
			} 
		} 
		public static int SEARCHES_PROJECTION_SEARCH_INDEX
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SEARCHES_PROJECTION_DATE_INDEX
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.Browser.staticClass = @__class; 
			global::android.provider.Browser._saveBookmark5851 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "saveBookmark", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.provider.Browser._sendString5852 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "sendString", "(Landroid/content/Context;Ljava/lang/String;)V"); 
			global::android.provider.Browser._getAllBookmarks5853 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "getAllBookmarks", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;"); 
			global::android.provider.Browser._getAllVisitedUrls5854 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "getAllVisitedUrls", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;"); 
			global::android.provider.Browser._updateVisitedHistory5855 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "updateVisitedHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;Z)V"); 
			global::android.provider.Browser._truncateHistory5856 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "truncateHistory", "(Landroid/content/ContentResolver;)V"); 
			global::android.provider.Browser._canClearHistory5857 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "canClearHistory", "(Landroid/content/ContentResolver;)Z"); 
			global::android.provider.Browser._clearHistory5858 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "clearHistory", "(Landroid/content/ContentResolver;)V"); 
			global::android.provider.Browser._deleteHistoryTimeFrame5859 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "deleteHistoryTimeFrame", "(Landroid/content/ContentResolver;JJ)V"); 
			global::android.provider.Browser._deleteFromHistory5860 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "deleteFromHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;)V"); 
			global::android.provider.Browser._addSearchUrl5861 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "addSearchUrl", "(Landroid/content/ContentResolver;Ljava/lang/String;)V"); 
			global::android.provider.Browser._clearSearches5862 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "clearSearches", "(Landroid/content/ContentResolver;)V"); 
			global::android.provider.Browser._requestAllIcons5863 = @__env.GetStaticMethodID(global::android.provider.Browser.staticClass, "requestAllIcons", "(Landroid/content/ContentResolver;Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V"); 
			global::android.provider.Browser._Browser5864 = @__env.GetMethodID(global::android.provider.Browser.staticClass, "<init>", "()V"); 
		} 
	} 
} 
