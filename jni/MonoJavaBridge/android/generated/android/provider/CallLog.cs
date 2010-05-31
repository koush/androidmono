namespace android.provider
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CallLog : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CallLog()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.CallLog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.provider.CallLog(@__env);
			}
		}
		protected CallLog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Calls : java.lang.Object, BaseColumns
		{
			internal static global::java.lang.Class staticClass;
			static Calls()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.CallLog.Calls), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.provider.CallLog.Calls(@__env);
				}
			}
			protected Calls(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _Calls6149;
			public Calls()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.provider.CallLog.Calls.staticClass, global::android.provider.CallLog.Calls._Calls6149, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6150;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					return default(global::android.net.Uri);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_FILTER_URI6151;
			public static global::android.net.Uri CONTENT_FILTER_URI
			{
				get
				{
					return default(global::android.net.Uri);
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.provider.CallLog.Calls.staticClass = @__class;
				global::android.provider.CallLog.Calls._Calls6149 = @__env.GetMethodID(global::android.provider.CallLog.Calls.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _CallLog6152;
		public CallLog()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.provider.CallLog.staticClass, global::android.provider.CallLog._CallLog6152, this);
		}
		public static global::java.lang.String AUTHORITY
		{
			get
			{
				return "call_log";
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6153;
		public static global::android.net.Uri CONTENT_URI
		{
			get
			{
				return default(global::android.net.Uri);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.provider.CallLog.staticClass = @__class;
			global::android.provider.CallLog._CallLog6152 = @__env.GetMethodID(global::android.provider.CallLog.staticClass, "<init>", "()V");
		}
	}
}
