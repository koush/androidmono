namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConsoleMessage : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConsoleMessage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class MessageLevel : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal MessageLevel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.webkit.ConsoleMessage.MessageLevel[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.ConsoleMessage.MessageLevel._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.ConsoleMessage.MessageLevel._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "values", "()[Landroid/webkit/ConsoleMessage/MessageLevel;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.ConsoleMessage.MessageLevel>(@__env.CallStaticObjectMethod(android.webkit.ConsoleMessage.MessageLevel.staticClass, global::android.webkit.ConsoleMessage.MessageLevel._m0)) as android.webkit.ConsoleMessage.MessageLevel[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.webkit.ConsoleMessage.MessageLevel valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.ConsoleMessage.MessageLevel._m1.native == global::System.IntPtr.Zero)
					global::android.webkit.ConsoleMessage.MessageLevel._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/ConsoleMessage$MessageLevel;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.ConsoleMessage.MessageLevel>(@__env.CallStaticObjectMethod(android.webkit.ConsoleMessage.MessageLevel.staticClass, global::android.webkit.ConsoleMessage.MessageLevel._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.ConsoleMessage.MessageLevel;
			}
			internal static global::MonoJavaBridge.FieldId _DEBUG5969;
			public static global::android.webkit.ConsoleMessage.MessageLevel DEBUG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.ConsoleMessage.MessageLevel>(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _DEBUG5969)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ERROR5970;
			public static global::android.webkit.ConsoleMessage.MessageLevel ERROR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.ConsoleMessage.MessageLevel>(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _ERROR5970)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOG5971;
			public static global::android.webkit.ConsoleMessage.MessageLevel LOG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.ConsoleMessage.MessageLevel>(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _LOG5971)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIP5972;
			public static global::android.webkit.ConsoleMessage.MessageLevel TIP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.ConsoleMessage.MessageLevel>(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _TIP5972)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WARNING5973;
			public static global::android.webkit.ConsoleMessage.MessageLevel WARNING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.ConsoleMessage.MessageLevel>(@__env.GetStaticObjectField(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, _WARNING5973)) as android.webkit.ConsoleMessage.MessageLevel;
				}
			}
			static MessageLevel()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.ConsoleMessage.MessageLevel.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ConsoleMessage$MessageLevel"));
				global::android.webkit.ConsoleMessage.MessageLevel._DEBUG5969 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "DEBUG", "Landroid/webkit/ConsoleMessage$MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._ERROR5970 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "ERROR", "Landroid/webkit/ConsoleMessage$MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._LOG5971 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "LOG", "Landroid/webkit/ConsoleMessage$MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._TIP5972 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "TIP", "Landroid/webkit/ConsoleMessage$MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._WARNING5973 = @__env.GetStaticFieldIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "WARNING", "Landroid/webkit/ConsoleMessage$MessageLevel;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int lineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.ConsoleMessage.staticClass, "lineNumber", "()I", ref global::android.webkit.ConsoleMessage._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String message()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.ConsoleMessage.staticClass, "message", "()Ljava/lang/String;", ref global::android.webkit.ConsoleMessage._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String sourceId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.ConsoleMessage.staticClass, "sourceId", "()Ljava/lang/String;", ref global::android.webkit.ConsoleMessage._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.webkit.ConsoleMessage.MessageLevel messageLevel()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.webkit.ConsoleMessage.MessageLevel>(this, global::android.webkit.ConsoleMessage.staticClass, "messageLevel", "()Landroid/webkit/ConsoleMessage$MessageLevel;", ref global::android.webkit.ConsoleMessage._m3) as android.webkit.ConsoleMessage.MessageLevel;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ConsoleMessage(java.lang.String arg0, java.lang.String arg1, int arg2, android.webkit.ConsoleMessage.MessageLevel arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.ConsoleMessage._m4.native == global::System.IntPtr.Zero)
				global::android.webkit.ConsoleMessage._m4 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILandroid/webkit/ConsoleMessage$MessageLevel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static ConsoleMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.ConsoleMessage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ConsoleMessage"));
		}
		internal static void InitJNI()
		{
		}
	}
}
