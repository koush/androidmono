namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CallLog : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CallLog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Calls : java.lang.Object, BaseColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Calls(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.lang.String getLastOutgoingCall(android.content.Context arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.CallLog.Calls._m0.native == global::System.IntPtr.Zero)
					global::android.provider.CallLog.Calls._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.CallLog.Calls.staticClass, "getLastOutgoingCall", "(Landroid/content/Context;)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.provider.CallLog.Calls.staticClass, global::android.provider.CallLog.Calls._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public Calls() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.CallLog.Calls._m1.native == global::System.IntPtr.Zero)
					global::android.provider.CallLog.Calls._m1 = @__env.GetMethodIDNoThrow(global::android.provider.CallLog.Calls.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.CallLog.Calls.staticClass, global::android.provider.CallLog.Calls._m1);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4087;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.CallLog.Calls.staticClass, _CONTENT_URI4087)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_FILTER_URI4088;
			public static global::android.net.Uri CONTENT_FILTER_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.CallLog.Calls.staticClass, _CONTENT_FILTER_URI4088)) as android.net.Uri;
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "date DESC";
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/calls";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/calls";
				}
			}
			public static global::java.lang.String TYPE
			{
				get
				{
					return "type";
				}
			}
			public static int INCOMING_TYPE
			{
				get
				{
					return 1;
				}
			}
			public static int OUTGOING_TYPE
			{
				get
				{
					return 2;
				}
			}
			public static int MISSED_TYPE
			{
				get
				{
					return 3;
				}
			}
			public static global::java.lang.String NUMBER
			{
				get
				{
					return "number";
				}
			}
			public static global::java.lang.String DATE
			{
				get
				{
					return "date";
				}
			}
			public static global::java.lang.String DURATION
			{
				get
				{
					return "duration";
				}
			}
			public static global::java.lang.String NEW
			{
				get
				{
					return "new";
				}
			}
			public static global::java.lang.String CACHED_NAME
			{
				get
				{
					return "name";
				}
			}
			public static global::java.lang.String CACHED_NUMBER_TYPE
			{
				get
				{
					return "numbertype";
				}
			}
			public static global::java.lang.String CACHED_NUMBER_LABEL
			{
				get
				{
					return "numberlabel";
				}
			}
			static Calls()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.CallLog.Calls.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/CallLog$Calls"));
				global::android.provider.CallLog.Calls._CONTENT_URI4087 = @__env.GetStaticFieldIDNoThrow(global::android.provider.CallLog.Calls.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				global::android.provider.CallLog.Calls._CONTENT_FILTER_URI4088 = @__env.GetStaticFieldIDNoThrow(global::android.provider.CallLog.Calls.staticClass, "CONTENT_FILTER_URI", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CallLog() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.CallLog._m0.native == global::System.IntPtr.Zero)
				global::android.provider.CallLog._m0 = @__env.GetMethodIDNoThrow(global::android.provider.CallLog.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.CallLog.staticClass, global::android.provider.CallLog._m0);
			Init(@__env, handle);
		}
		public static global::java.lang.String AUTHORITY
		{
			get
			{
				return "call_log";
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONTENT_URI4104;
		public static global::android.net.Uri CONTENT_URI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.CallLog.staticClass, _CONTENT_URI4104)) as android.net.Uri;
			}
		}
		static CallLog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.CallLog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/CallLog"));
			global::android.provider.CallLog._CONTENT_URI4104 = @__env.GetStaticFieldIDNoThrow(global::android.provider.CallLog.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
		}
		internal static void InitJNI()
		{
		}
	}
}
