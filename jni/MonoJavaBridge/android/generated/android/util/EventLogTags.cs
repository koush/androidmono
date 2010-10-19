namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EventLogTags : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EventLogTags()
		{
			InitJNI();
		}
		protected EventLogTags(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Description : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Description()
			{
				InitJNI();
			}
			protected Description(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _mTag9058;
			public int mTag
			{
				get
				{
					return default(int);
				}
			}
			internal static global::MonoJavaBridge.FieldId _mName9059;
			public global::java.lang.String mName
			{
				get
				{
					return default(global::java.lang.String);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.EventLogTags.Description.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLogTags$Description"));
			}
		}
		internal static global::MonoJavaBridge.MethodId _get9060;
		public virtual global::android.util.EventLogTags.Description get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.EventLogTags._get9060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get9060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
		}
		internal static global::MonoJavaBridge.MethodId _get9061;
		public virtual global::android.util.EventLogTags.Description get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.EventLogTags._get9061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get9061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
		}
		internal static global::MonoJavaBridge.MethodId _EventLogTags9062;
		public EventLogTags()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags9062);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EventLogTags9063;
		public EventLogTags(java.io.BufferedReader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags9063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.EventLogTags.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLogTags"));
			global::android.util.EventLogTags._get9060 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "get", "(Ljava/lang/String;)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._get9061 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "get", "(I)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._EventLogTags9062 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "()V");
			global::android.util.EventLogTags._EventLogTags9063 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "(Ljava/io/BufferedReader;)V");
		}
	}
}
