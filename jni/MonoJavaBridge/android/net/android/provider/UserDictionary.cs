namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class UserDictionary : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static UserDictionary() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.UserDictionary), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.UserDictionary(@__env); 
			} 
		} 
		protected UserDictionary(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Words : java.lang.Object, BaseColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Words() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.UserDictionary.Words), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.UserDictionary.Words(@__env); 
				} 
			} 
			protected Words(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addWord6369; 
			public static void addWord(android.content.Context arg0, java.lang.String arg1, int arg2, int arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.UserDictionary.Words.staticClass, global::android.provider.UserDictionary.Words._addWord6369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Words6370; 
			public Words()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.UserDictionary.Words.staticClass, global::android.provider.UserDictionary.Words._Words6370, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6371; 
			public static global::android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(global::android.net.Uri); 
				} 
			} 
			public static global::java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/vnd.google.userword"; 
				} 
			} 
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/vnd.google.userword"; 
				} 
			} 
			public static global::java.lang.String _ID
			{ 
				get 
				{ 
					return "_id"; 
				} 
			} 
			public static global::java.lang.String WORD
			{ 
				get 
				{ 
					return "word"; 
				} 
			} 
			public static global::java.lang.String FREQUENCY
			{ 
				get 
				{ 
					return "frequency"; 
				} 
			} 
			public static global::java.lang.String LOCALE
			{ 
				get 
				{ 
					return "locale"; 
				} 
			} 
			public static global::java.lang.String APP_ID
			{ 
				get 
				{ 
					return "appid"; 
				} 
			} 
			public static int LOCALE_TYPE_ALL
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int LOCALE_TYPE_CURRENT
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "frequency DESC"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.UserDictionary.Words.staticClass = @__class; 
				global::android.provider.UserDictionary.Words._addWord6369 = @__env.GetStaticMethodID(global::android.provider.UserDictionary.Words.staticClass, "addWord", "(Landroid/content/Context;Ljava/lang/String;II)V"); 
				global::android.provider.UserDictionary.Words._Words6370 = @__env.GetMethodID(global::android.provider.UserDictionary.Words.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UserDictionary6372; 
		public UserDictionary()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.provider.UserDictionary.staticClass, global::android.provider.UserDictionary._UserDictionary6372, this); 
		} 
		public static global::java.lang.String AUTHORITY
		{ 
			get 
			{ 
				return "user_dictionary"; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6373; 
		public static global::android.net.Uri CONTENT_URI
		{ 
			get 
			{ 
				return default(global::android.net.Uri); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.UserDictionary.staticClass = @__class; 
			global::android.provider.UserDictionary._UserDictionary6372 = @__env.GetMethodID(global::android.provider.UserDictionary.staticClass, "<init>", "()V"); 
		} 
	} 
} 
