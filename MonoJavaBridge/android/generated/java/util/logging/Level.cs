namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Level : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Level(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.Level.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.logging.Level._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Level.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.logging.Level._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.logging.Level.staticClass, "hashCode", "()I", ref global::java.util.logging.Level._m2);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Level.staticClass, "getName", "()Ljava/lang/String;", ref global::java.util.logging.Level._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.logging.Level.staticClass, "intValue", "()I", ref global::java.util.logging.Level._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.util.logging.Level parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Level._m5.native == global::System.IntPtr.Zero)
				global::java.util.logging.Level._m5 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Level.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/logging/Level;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Level.staticClass, global::java.util.logging.Level._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Level;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getResourceBundleName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Level.staticClass, "getResourceBundleName", "()Ljava/lang/String;", ref global::java.util.logging.Level._m6) as java.lang.String;
		}
		public new global::java.lang.String LocalizedName
		{
			get
			{
				return getLocalizedName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getLocalizedName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Level.staticClass, "getLocalizedName", "()Ljava/lang/String;", ref global::java.util.logging.Level._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected Level(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Level._m8.native == global::System.IntPtr.Zero)
				global::java.util.logging.Level._m8 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected Level(java.lang.String arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Level._m9.native == global::System.IntPtr.Zero)
				global::java.util.logging.Level._m9 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _OFF6885;
		public static global::java.util.logging.Level OFF
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _OFF6885)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SEVERE6886;
		public static global::java.util.logging.Level SEVERE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _SEVERE6886)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _WARNING6887;
		public static global::java.util.logging.Level WARNING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _WARNING6887)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INFO6888;
		public static global::java.util.logging.Level INFO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _INFO6888)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONFIG6889;
		public static global::java.util.logging.Level CONFIG
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _CONFIG6889)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINE6890;
		public static global::java.util.logging.Level FINE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINE6890)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINER6891;
		public static global::java.util.logging.Level FINER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINER6891)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINEST6892;
		public static global::java.util.logging.Level FINEST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINEST6892)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALL6893;
		public static global::java.util.logging.Level ALL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _ALL6893)) as java.util.logging.Level;
			}
		}
		static Level()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Level.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Level"));
			global::java.util.logging.Level._OFF6885 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "OFF", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._SEVERE6886 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "SEVERE", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._WARNING6887 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "WARNING", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._INFO6888 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "INFO", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._CONFIG6889 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "CONFIG", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINE6890 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINE", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINER6891 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINER", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINEST6892 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINEST", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._ALL6893 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "ALL", "Ljava/util/logging/Level;");
		}
	}
}
