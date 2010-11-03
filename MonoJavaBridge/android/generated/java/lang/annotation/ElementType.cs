namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ElementType : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ElementType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.annotation.ElementType[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.ElementType._m0.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.ElementType._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "values", "()[Ljava/lang/annotation/ElementType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.ElementType>(@__env.CallStaticObjectMethod(java.lang.annotation.ElementType.staticClass, global::java.lang.annotation.ElementType._m0)) as java.lang.annotation.ElementType[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.annotation.ElementType valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.ElementType._m1.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.ElementType._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/ElementType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.CallStaticObjectMethod(java.lang.annotation.ElementType.staticClass, global::java.lang.annotation.ElementType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.ElementType;
		}
		internal static global::MonoJavaBridge.FieldId _TYPE6400;
		public static global::java.lang.annotation.ElementType TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _TYPE6400)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FIELD6401;
		public static global::java.lang.annotation.ElementType FIELD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _FIELD6401)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _METHOD6402;
		public static global::java.lang.annotation.ElementType METHOD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _METHOD6402)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PARAMETER6403;
		public static global::java.lang.annotation.ElementType PARAMETER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _PARAMETER6403)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONSTRUCTOR6404;
		public static global::java.lang.annotation.ElementType CONSTRUCTOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _CONSTRUCTOR6404)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _LOCAL_VARIABLE6405;
		public static global::java.lang.annotation.ElementType LOCAL_VARIABLE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _LOCAL_VARIABLE6405)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANNOTATION_TYPE6406;
		public static global::java.lang.annotation.ElementType ANNOTATION_TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _ANNOTATION_TYPE6406)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PACKAGE6407;
		public static global::java.lang.annotation.ElementType PACKAGE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _PACKAGE6407)) as java.lang.annotation.ElementType;
			}
		}
		static ElementType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.ElementType.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/ElementType"));
			global::java.lang.annotation.ElementType._TYPE6400 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "TYPE", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._FIELD6401 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "FIELD", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._METHOD6402 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "METHOD", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._PARAMETER6403 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "PARAMETER", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._CONSTRUCTOR6404 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "CONSTRUCTOR", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._LOCAL_VARIABLE6405 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "LOCAL_VARIABLE", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._ANNOTATION_TYPE6406 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "ANNOTATION_TYPE", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._PACKAGE6407 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "PACKAGE", "Ljava/lang/annotation/ElementType;");
		}
	}
}
