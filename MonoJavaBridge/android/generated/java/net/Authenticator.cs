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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.net.Authenticator.RequestorType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.net.Authenticator.RequestorType._m0.native == global::System.IntPtr.Zero)
					global::java.net.Authenticator.RequestorType._m0 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "values", "()[Ljava/net/Authenticator/RequestorType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.Authenticator.RequestorType>(@__env.CallStaticObjectMethod(java.net.Authenticator.RequestorType.staticClass, global::java.net.Authenticator.RequestorType._m0)) as java.net.Authenticator.RequestorType[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.net.Authenticator.RequestorType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.net.Authenticator.RequestorType._m1.native == global::System.IntPtr.Zero)
					global::java.net.Authenticator.RequestorType._m1 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/net/Authenticator$RequestorType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.CallStaticObjectMethod(java.net.Authenticator.RequestorType.staticClass, global::java.net.Authenticator.RequestorType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.Authenticator.RequestorType;
			}
			internal static global::MonoJavaBridge.FieldId _PROXY6451;
			public static global::java.net.Authenticator.RequestorType PROXY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.GetStaticObjectField(global::java.net.Authenticator.RequestorType.staticClass, _PROXY6451)) as java.net.Authenticator.RequestorType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SERVER6452;
			public static global::java.net.Authenticator.RequestorType SERVER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.GetStaticObjectField(global::java.net.Authenticator.RequestorType.staticClass, _SERVER6452)) as java.net.Authenticator.RequestorType;
				}
			}
			static RequestorType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.net.Authenticator.RequestorType.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Authenticator$RequestorType"));
				global::java.net.Authenticator.RequestorType._PROXY6451 = @__env.GetStaticFieldIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "PROXY", "Ljava/net/Authenticator$RequestorType;");
				global::java.net.Authenticator.RequestorType._SERVER6452 = @__env.GetStaticFieldIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "SERVER", "Ljava/net/Authenticator$RequestorType;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void setDefault(java.net.Authenticator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._m0.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._m0 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "setDefault", "(Ljava/net/Authenticator;)V");
			@__env.CallStaticVoidMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.net.PasswordAuthentication requestPasswordAuthentication(java.net.InetAddress arg0, int arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._m1.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._m1 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "requestPasswordAuthentication", "(Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallStaticObjectMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.net.PasswordAuthentication;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.net.PasswordAuthentication requestPasswordAuthentication(java.lang.String arg0, java.net.InetAddress arg1, int arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._m2.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._m2 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallStaticObjectMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.PasswordAuthentication;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.net.PasswordAuthentication requestPasswordAuthentication(java.lang.String arg0, java.net.InetAddress arg1, int arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.net.URL arg6, java.net.Authenticator.RequestorType arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._m3.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._m3 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;Ljava/net/Authenticator$RequestorType;)Ljava/net/PasswordAuthentication;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallStaticObjectMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.net.PasswordAuthentication;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual global::java.lang.String getRequestingHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Authenticator.staticClass, "getRequestingHost", "()Ljava/lang/String;", ref global::java.net.Authenticator._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual global::java.net.InetAddress getRequestingSite()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Authenticator.staticClass, "getRequestingSite", "()Ljava/net/InetAddress;", ref global::java.net.Authenticator._m5) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual int getRequestingPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Authenticator.staticClass, "getRequestingPort", "()I", ref global::java.net.Authenticator._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual global::java.lang.String getRequestingProtocol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Authenticator.staticClass, "getRequestingProtocol", "()Ljava/lang/String;", ref global::java.net.Authenticator._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual global::java.lang.String getRequestingPrompt()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Authenticator.staticClass, "getRequestingPrompt", "()Ljava/lang/String;", ref global::java.net.Authenticator._m8) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::java.lang.String getRequestingScheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Authenticator.staticClass, "getRequestingScheme", "()Ljava/lang/String;", ref global::java.net.Authenticator._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual global::java.net.PasswordAuthentication getPasswordAuthentication()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.PasswordAuthentication>(this, global::java.net.Authenticator.staticClass, "getPasswordAuthentication", "()Ljava/net/PasswordAuthentication;", ref global::java.net.Authenticator._m10) as java.net.PasswordAuthentication;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual global::java.net.URL getRequestingURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.net.Authenticator.staticClass, "getRequestingURL", "()Ljava/net/URL;", ref global::java.net.Authenticator._m11) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual global::java.net.Authenticator.RequestorType getRequestorType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.Authenticator.RequestorType>(this, global::java.net.Authenticator.staticClass, "getRequestorType", "()Ljava/net/Authenticator$RequestorType;", ref global::java.net.Authenticator._m12) as java.net.Authenticator.RequestorType;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public Authenticator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Authenticator._m13.native == global::System.IntPtr.Zero)
				global::java.net.Authenticator._m13 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Authenticator.staticClass, global::java.net.Authenticator._m13);
			Init(@__env, handle);
		}
		static Authenticator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Authenticator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Authenticator"));
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
	}
}
