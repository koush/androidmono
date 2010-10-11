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
			internal static global::MonoJavaBridge.FieldId _mTag8512;
			public int mTag
			{
				get
				{
					return default(int);
				}
			}
			internal static global::MonoJavaBridge.FieldId _mName8513;
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
		internal static global::MonoJavaBridge.MethodId _get8514;
		public virtual global::android.util.EventLogTags.Description get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.EventLogTags._get8514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get8514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
		}
		internal static global::MonoJavaBridge.MethodId _get8515;
		public virtual global::android.util.EventLogTags.Description get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.EventLogTags._get8515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get8515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
		}
		internal static global::MonoJavaBridge.MethodId _EventLogTags8516;
		public EventLogTags()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags8516);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EventLogTags8517;
		public EventLogTags(java.io.BufferedReader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags8517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.EventLogTags.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLogTags"));
			global::android.util.EventLogTags._get8514 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "get", "(Ljava/lang/String;)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._get8515 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "get", "(I)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._EventLogTags8516 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "()V");
			global::android.util.EventLogTags._EventLogTags8517 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "(Ljava/io/BufferedReader;)V");
		}
	}
}
