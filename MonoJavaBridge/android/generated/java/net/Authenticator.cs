namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.Authenticator_))]
	public abstract partial class Authenticator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Authenticator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class RequestorType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal RequestorType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values21329;
			public static global::java.net.Authenticator.RequestorType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.net.Authenticator.RequestorType._values21329.native == global::System.IntPtr.Zero)
					global::java.net.Authenticator.RequestorType._values21329 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "values", "()[Ljava/net/Authenticator/RequestorType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.Authenticator.RequestorType>(@__env.CallStaticObjectMethod(java.net.Authenticator.RequestorType.staticClass, global::java.net.Authenticator.RequestorType._values21329)) as java.net.Authenticator.RequestorType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf21330;
			public static global::java.net.Authenticator.RequestorType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.net.Authenticator.RequestorType._valueOf21330.native == global::System.IntPtr.Zero)
					global::java.net.Authenticator.RequestorType._valueOf21330 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/net/Authenticator$RequestorType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.CallStaticObjectMethod(java.net.Authenticator.RequestorType.staticClass, global::java.net.Authenticator.RequestorType._valueOf21330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.Authenticator.RequestorType;
			}
			internal static global::MonoJavaBridge.FieldId _PROXY21331;
			public static global::java.net.Authenticator.RequestorType PROXY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.GetStaticObjectField(global::java.net.Authenticator.RequestorType.staticClass, _PROXY21331)) as java.net.Authenticator.RequestorType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SERVER21332;
			public static global::java.net.Authenticator.RequestorType SERVER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.GetStaticObjectField(global::java.net.Authenticator.RequestorType.staticClass, _SERVER21332)) as java.net.Authenticator.RequestorType;
				}
			}
			static RequestorType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.net.Authenticator.RequestorType.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Authenticator$RequestorType"));
				global::java.net.Authenticator.RequestorType._PROXY21331 = @__env.GetStaticFieldIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "PROXY", "Ljava/net/Authenticator$RequestorType;");
				global::java.net.Authenticator.RequestorType._SERVER21332 = @__env.GetStaticFieldIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "SERVER", "Ljava/net/Authenticator$RequestorType;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDefault21333;
		public static void setDefault(java.net.Authenticator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._setDefault21333.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._setDefault21333 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "setDefault", "(Ljava/net/Authenticator;)V");
			@__env.CallStaticVoidMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._setDefault21333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestPasswordAuthentication21334;
		public static global::java.net.PasswordAuthentication requestPasswordAuthentication(java.net.InetAddress arg0, int arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._requestPasswordAuthentication21334.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._requestPasswordAuthentication21334 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "requestPasswordAuthentication", "(Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallStaticObjectMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._requestPasswordAuthentication21334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.net.PasswordAuthentication;
		}
		internal static global::MonoJavaBridge.MethodId _requestPasswordAuthentication21335;
		public static global::java.net.PasswordAuthentication requestPasswordAuthentication(java.lang.String arg0, java.net.InetAddress arg1, int arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._requestPasswordAuthentication21335.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._requestPasswordAuthentication21335 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallStaticObjectMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._requestPasswordAuthentication21335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.PasswordAuthentication;
		}
		internal static global::MonoJavaBridge.MethodId _requestPasswordAuthentication21336;
		public static global::java.net.PasswordAuthentication requestPasswordAuthentication(java.lang.String arg0, java.net.InetAddress arg1, int arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.net.URL arg6, java.net.Authenticator.RequestorType arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._requestPasswordAuthentication21336.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._requestPasswordAuthentication21336 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;Ljava/net/Authenticator$RequestorType;)Ljava/net/PasswordAuthentication;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallStaticObjectMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._requestPasswordAuthentication21336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.net.PasswordAuthentication;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingHost21337;
		protected virtual global::java.lang.String getRequestingHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Authenticator.staticClass, "getRequestingHost", "()Ljava/lang/String;", ref global::java.net.Authenticator._getRequestingHost21337) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingSite21338;
		protected virtual global::java.net.InetAddress getRequestingSite()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Authenticator.staticClass, "getRequestingSite", "()Ljava/net/InetAddress;", ref global::java.net.Authenticator._getRequestingSite21338) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingPort21339;
		protected virtual int getRequestingPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Authenticator.staticClass, "getRequestingPort", "()I", ref global::java.net.Authenticator._getRequestingPort21339);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingProtocol21340;
		protected virtual global::java.lang.String getRequestingProtocol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Authenticator.staticClass, "getRequestingProtocol", "()Ljava/lang/String;", ref global::java.net.Authenticator._getRequestingProtocol21340) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingPrompt21341;
		protected virtual global::java.lang.String getRequestingPrompt()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Authenticator.staticClass, "getRequestingPrompt", "()Ljava/lang/String;", ref global::java.net.Authenticator._getRequestingPrompt21341) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingScheme21342;
		protected virtual global::java.lang.String getRequestingScheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Authenticator.staticClass, "getRequestingScheme", "()Ljava/lang/String;", ref global::java.net.Authenticator._getRequestingScheme21342) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPasswordAuthentication21343;
		protected virtual global::java.net.PasswordAuthentication getPasswordAuthentication()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.PasswordAuthentication>(this, global::java.net.Authenticator.staticClass, "getPasswordAuthentication", "()Ljava/net/PasswordAuthentication;", ref global::java.net.Authenticator._getPasswordAuthentication21343) as java.net.PasswordAuthentication;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingURL21344;
		protected virtual global::java.net.URL getRequestingURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.net.Authenticator.staticClass, "getRequestingURL", "()Ljava/net/URL;", ref global::java.net.Authenticator._getRequestingURL21344) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestorType21345;
		protected virtual global::java.net.Authenticator.RequestorType getRequestorType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.Authenticator.RequestorType>(this, global::java.net.Authenticator.staticClass, "getRequestorType", "()Ljava/net/Authenticator$RequestorType;", ref global::java.net.Authenticator._getRequestorType21345) as java.net.Authenticator.RequestorType;
		}
		internal static global::MonoJavaBridge.MethodId _Authenticator21346;
		public Authenticator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._Authenticator21346.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._Authenticator21346 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Authenticator.staticClass, global::java.net.Authenticator._Authenticator21346);
			Init(@__env, handle);
		}
		static Authenticator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Authenticator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Authenticator"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.Authenticator))]
	internal sealed partial class Authenticator_ : java.net.Authenticator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Authenticator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Authenticator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Authenticator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Authenticator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
