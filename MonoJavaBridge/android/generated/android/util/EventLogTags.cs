namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EventLogTags : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EventLogTags(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Description : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Description(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _mTag5392;
			public int mTag
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _mTag5392);
				}
			}
			internal static global::MonoJavaBridge.FieldId _mName5393;
			public global::java.lang.String mName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _mName5393)) as java.lang.String;
				}
			}
			static Description()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.EventLogTags.Description.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLogTags$Description"));
				global::android.util.EventLogTags.Description._mTag5392 = @__env.GetFieldIDNoThrow(global::android.util.EventLogTags.Description.staticClass, "mTag", "I");
				global::android.util.EventLogTags.Description._mName5393 = @__env.GetFieldIDNoThrow(global::android.util.EventLogTags.Description.staticClass, "mName", "Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.util.EventLogTags.Description get(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.util.EventLogTags.staticClass, "get", "(Ljava/lang/String;)Landroid/util/EventLogTags$Description;", ref global::android.util.EventLogTags._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.util.EventLogTags.Description;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.util.EventLogTags.Description get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.util.EventLogTags.staticClass, "get", "(I)Landroid/util/EventLogTags$Description;", ref global::android.util.EventLogTags._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.util.EventLogTags.Description;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public EventLogTags() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLogTags._m2.native == global::System.IntPtr.Zero)
				global::android.util.EventLogTags._m2 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._m2);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public EventLogTags(java.io.BufferedReader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLogTags._m3.native == global::System.IntPtr.Zero)
				global::android.util.EventLogTags._m3 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "(Ljava/io/BufferedReader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EventLogTags()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.EventLogTags.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLogTags"));
		}
		internal static void InitJNI()
		{
		}
	}
}
