namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ConsoleMessage : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ConsoleMessage()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.ConsoleMessage), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.ConsoleMessage(@__env);
			}
		}
		protected ConsoleMessage(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class MessageLevel : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static MessageLevel()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.ConsoleMessage.MessageLevel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.ConsoleMessage.MessageLevel(@__env);
				}
			}
			internal MessageLevel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values9937;
			public static global::android.webkit.ConsoleMessage.MessageLevel[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.ConsoleMessage.MessageLevel.staticClass, global::android.webkit.ConsoleMessage.MessageLevel._values9937));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf9938;
			public static global::android.webkit.ConsoleMessage.MessageLevel valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.ConsoleMessage.MessageLevel>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.ConsoleMessage.MessageLevel.staticClass, global::android.webkit.ConsoleMessage.MessageLevel._valueOf9938, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _DEBUG9939;
			public static global::android.webkit.ConsoleMessage.MessageLevel DEBUG
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ERROR9940;
			public static global::android.webkit.ConsoleMessage.MessageLevel ERROR
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _LOG9941;
			public static global::android.webkit.ConsoleMessage.MessageLevel LOG
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TIP9942;
			public static global::android.webkit.ConsoleMessage.MessageLevel TIP
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _WARNING9943;
			public static global::android.webkit.ConsoleMessage.MessageLevel WARNING
			{
				get
				{
					return default(global::android.webkit.ConsoleMessage.MessageLevel);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.ConsoleMessage.MessageLevel.staticClass = @__class;
				global::android.webkit.ConsoleMessage.MessageLevel._values9937 = @__env.GetStaticMethodID(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "values", "()[Landroid/webkit/ConsoleMessage/MessageLevel;");
				global::android.webkit.ConsoleMessage.MessageLevel._valueOf9938 = @__env.GetStaticMethodID(global::android.webkit.ConsoleMessage.MessageLevel.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/webkit/ConsoleMessage$MessageLevel;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _lineNumber9944;
		public virtual int lineNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.ConsoleMessage._lineNumber9944);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._lineNumber9944);
		}
		internal static global::net.sf.jni4net.jni.MethodId _message9945;
		public virtual global::java.lang.String message() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.ConsoleMessage._message9945));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._message9945));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sourceId9946;
		public virtual global::java.lang.String sourceId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.ConsoleMessage._sourceId9946));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._sourceId9946));
		}
		internal static global::net.sf.jni4net.jni.MethodId _messageLevel9947;
		public virtual global::android.webkit.ConsoleMessage.MessageLevel messageLevel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.ConsoleMessage.MessageLevel>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.ConsoleMessage._messageLevel9947));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.ConsoleMessage.MessageLevel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._messageLevel9947));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ConsoleMessage9948;
		public ConsoleMessage(java.lang.String arg0, java.lang.String arg1, int arg2, android.webkit.ConsoleMessage.MessageLevel arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.ConsoleMessage.staticClass, global::android.webkit.ConsoleMessage._ConsoleMessage9948, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.ConsoleMessage.staticClass = @__class;
			global::android.webkit.ConsoleMessage._lineNumber9944 = @__env.GetMethodID(global::android.webkit.ConsoleMessage.staticClass, "lineNumber", "()I");
			global::android.webkit.ConsoleMessage._message9945 = @__env.GetMethodID(global::android.webkit.ConsoleMessage.staticClass, "message", "()Ljava/lang/String;");
			global::android.webkit.ConsoleMessage._sourceId9946 = @__env.GetMethodID(global::android.webkit.ConsoleMessage.staticClass, "sourceId", "()Ljava/lang/String;");
			global::android.webkit.ConsoleMessage._messageLevel9947 = @__env.GetMethodID(global::android.webkit.ConsoleMessage.staticClass, "messageLevel", "()Landroid/webkit/ConsoleMessage$MessageLevel;");
			global::android.webkit.ConsoleMessage._ConsoleMessage9948 = @__env.GetMethodID(global::android.webkit.ConsoleMessage.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILandroid/webkit/ConsoleMessage$MessageLevel;)V");
		}
	}
}
