namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConsoleMessage : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConsoleMessage()
		{
			InitJNI();
		}
		protected ConsoleMessage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class MessageLevel : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MessageLevel()
			{
				InitJNI();
			}
			internal MessageLevel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values10284;
			public static global::android.webkit.ConsoleMessage.MessageLevel[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.webkit.ConsoleMessage.MessageLevel>(@__env.CallStaticObjectMethod(android.webkit.ConsoleMessage.MessageLevel.staticClass, global::android.webkit.ConsoleMessage.MessageLevel._values10284)) as android.webkit.ConsoleMessage.MessageLevel[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10285;
			public static global::android.webkit.ConsoleMessage.MessageLevel valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.ConsoleMessage.MessageLevel.staticClass, global::android.webkit.ConsoleMessage.MessageLevel._valueOf10285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.ConsoleMessage.MessageLevel;
			}
			internal static global::MonoJavaBridge.FieldId _DEBUG10286;
			public static global::android.webkit.ConsoleMessage.MessageLevel DEBUG
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ERROR10287;
			public static global::android.webkit.ConsoleMessage.MessageLevel ERROR
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOG10288;
			public static global::android.webkit.ConsoleMessage.MessageLevel LOG
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIP10289;
			public static global::android.webkit.ConsoleMessage.MessageLevel TIP
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			internal static global::MonoJavaBridge.FieldId _WARNING10290;
			public static global::android.webkit.ConsoleMessage.MessageLevel WARNING
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.ConsoleMessage.MessageLevel.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ConsoleMessage$MessageLevel"));
				global::android.webkit.ConsoleMessage.MessageLevel._values10284 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "values", "()[Landroid/webkit/ConsoleMessage/MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._valueOf10285 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/ConsoleMessage$MessageLevel;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _lineNumber10291;
		public virtual int lineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.ConsoleMessage._lineNumber10291);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._lineNumber10291);
		}
		internal static global::MonoJavaBridge.MethodId _message10292;
		public virtual global::java.lang.String message() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage._message10292)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._message10292)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _sourceId10293;
		public virtual global::java.lang.String sourceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage._sourceId10293)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._sourceId10293)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _messageLevel10294;
		public virtual global::android.webkit.ConsoleMessage.MessageLevel messageLevel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage._messageLevel10294)) as android.webkit.ConsoleMessage.MessageLevel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._messageLevel10294)) as android.webkit.ConsoleMessage.MessageLevel;
		}
		internal static global::MonoJavaBridge.MethodId _ConsoleMessage10295;
		public ConsoleMessage(java.lang.String arg0, java.lang.String arg1, int arg2, android.webkit.ConsoleMessage.MessageLevel arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._ConsoleMessage10295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.ConsoleMessage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ConsoleMessage"));
			global::android.webkit.ConsoleMessage._lineNumber10291 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "lineNumber", "()I");
			global::android.webkit.ConsoleMessage._message10292 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "message", "()Ljava/lang/String;");
			global::android.webkit.ConsoleMessage._sourceId10293 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "sourceId", "()Ljava/lang/String;");
			global::android.webkit.ConsoleMessage._messageLevel10294 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "messageLevel", "()Landroid/webkit/ConsoleMessage$MessageLevel;");
			global::android.webkit.ConsoleMessage._ConsoleMessage10295 = @__env.GetMethodIDNoThrow(global::android.webkit.ConsoleMessage.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILandroid/webkit/ConsoleMessage$MessageLevel;)V");
		}
	}
}
