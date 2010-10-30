namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class VersionInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected VersionInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.util.VersionInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.util.VersionInfo._m0) as java.lang.String;
		}
		public new global::java.lang.String Package
		{
			get
			{
				return getPackage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.util.VersionInfo.staticClass, "getPackage", "()Ljava/lang/String;", ref global::org.apache.http.util.VersionInfo._m1) as java.lang.String;
		}
		public new global::java.lang.String Timestamp
		{
			get
			{
				return getTimestamp();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getTimestamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.util.VersionInfo.staticClass, "getTimestamp", "()Ljava/lang/String;", ref global::org.apache.http.util.VersionInfo._m2) as java.lang.String;
		}
		public new global::java.lang.String Module
		{
			get
			{
				return getModule();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getModule()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.util.VersionInfo.staticClass, "getModule", "()Ljava/lang/String;", ref global::org.apache.http.util.VersionInfo._m3) as java.lang.String;
		}
		public new global::java.lang.String Release
		{
			get
			{
				return getRelease();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getRelease()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.util.VersionInfo.staticClass, "getRelease", "()Ljava/lang/String;", ref global::org.apache.http.util.VersionInfo._m4) as java.lang.String;
		}
		public new global::java.lang.String Classloader
		{
			get
			{
				return getClassloader();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getClassloader()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.util.VersionInfo.staticClass, "getClassloader", "()Ljava/lang/String;", ref global::org.apache.http.util.VersionInfo._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::org.apache.http.util.VersionInfo[] loadVersionInfo(java.lang.String[] arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.VersionInfo._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.VersionInfo._m6 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "loadVersionInfo", "([Ljava/lang/String;Ljava/lang/ClassLoader;)[Lorg/apache/http/util/VersionInfo;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.util.VersionInfo>(@__env.CallStaticObjectMethod(org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.VersionInfo[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::org.apache.http.util.VersionInfo loadVersionInfo(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.VersionInfo._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.VersionInfo._m7 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "loadVersionInfo", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Lorg/apache/http/util/VersionInfo;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.VersionInfo;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected static global::org.apache.http.util.VersionInfo fromMap(java.lang.String arg0, java.util.Map arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.VersionInfo._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.VersionInfo._m8 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "fromMap", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/ClassLoader;)Lorg/apache/http/util/VersionInfo;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.VersionInfo;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected VersionInfo(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.VersionInfo._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.VersionInfo._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		public static global::java.lang.String UNAVAILABLE
		{
			get
			{
				return "UNAVAILABLE";
			}
		}
		public static global::java.lang.String VERSION_PROPERTY_FILE
		{
			get
			{
				return "version.properties";
			}
		}
		public static global::java.lang.String PROPERTY_MODULE
		{
			get
			{
				return "info.module";
			}
		}
		public static global::java.lang.String PROPERTY_RELEASE
		{
			get
			{
				return "info.release";
			}
		}
		public static global::java.lang.String PROPERTY_TIMESTAMP
		{
			get
			{
				return "info.timestamp";
			}
		}
		static VersionInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.VersionInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/VersionInfo"));
		}
		internal static void InitJNI()
		{
		}
	}
}
