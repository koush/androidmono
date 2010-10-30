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
			internal static global::MonoJavaBridge.FieldId _mTag13762;
			public int mTag
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _mTag13762);
				}
			}
			internal static global::MonoJavaBridge.FieldId _mName13763;
			public global::java.lang.String mName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _mName13763)) as java.lang.String;
				}
			}
			static Description()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.EventLogTags.Description.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLogTags$Description"));
				global::android.util.EventLogTags.Description._mTag13762 = @__env.GetFieldIDNoThrow(global::android.util.EventLogTags.Description.staticClass, "mTag", "I");
				global::android.util.EventLogTags.Description._mName13763 = @__env.GetFieldIDNoThrow(global::android.util.EventLogTags.Description.staticClass, "mName", "Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _get13764;
		public virtual global::android.util.EventLogTags.Description get(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get13764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
		}
		internal static global::MonoJavaBridge.MethodId _get13765;
		public virtual global::android.util.EventLogTags.Description get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get13765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
		}
		internal static global::MonoJavaBridge.MethodId _EventLogTags13766;
		public EventLogTags() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags13766);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EventLogTags13767;
		public EventLogTags(java.io.BufferedReader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags13767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EventLogTags()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.EventLogTags.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLogTags"));
			global::android.util.EventLogTags._get13764 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "get", "(Ljava/lang/String;)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._get13765 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "get", "(I)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._EventLogTags13766 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "()V");
			global::android.util.EventLogTags._EventLogTags13767 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "(Ljava/io/BufferedReader;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
