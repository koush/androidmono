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
			internal static global::MonoJavaBridge.FieldId _mTag13698;
			public int mTag
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _mTag13698);
				}
			}
			internal static global::MonoJavaBridge.FieldId _mName13699;
			public global::java.lang.String mName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _mName13699)) as java.lang.String;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.EventLogTags.Description.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLogTags$Description"));
				global::android.util.EventLogTags.Description._mTag13698 = @__env.GetFieldIDNoThrow(global::android.util.EventLogTags.Description.staticClass, "mTag", "I");
				global::android.util.EventLogTags.Description._mName13699 = @__env.GetFieldIDNoThrow(global::android.util.EventLogTags.Description.staticClass, "mName", "Ljava/lang/String;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _get13700;
		public virtual global::android.util.EventLogTags.Description get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.EventLogTags._get13700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get13700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
		}
		internal static global::MonoJavaBridge.MethodId _get13701;
		public virtual global::android.util.EventLogTags.Description get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.EventLogTags._get13701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get13701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.EventLogTags.Description;
		}
		internal static global::MonoJavaBridge.MethodId _EventLogTags13702;
		public EventLogTags()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags13702);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EventLogTags13703;
		public EventLogTags(java.io.BufferedReader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags13703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.EventLogTags.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLogTags"));
			global::android.util.EventLogTags._get13700 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "get", "(Ljava/lang/String;)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._get13701 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "get", "(I)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._EventLogTags13702 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "()V");
			global::android.util.EventLogTags._EventLogTags13703 = @__env.GetMethodIDNoThrow(global::android.util.EventLogTags.staticClass, "<init>", "(Ljava/io/BufferedReader;)V");
		}
	}
}
