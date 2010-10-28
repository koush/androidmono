namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ElementType : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ElementType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values20952;
		public static global::java.lang.annotation.ElementType[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.ElementType>(@__env.CallStaticObjectMethod(java.lang.annotation.ElementType.staticClass, global::java.lang.annotation.ElementType._values20952)) as java.lang.annotation.ElementType[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20953;
		public static global::java.lang.annotation.ElementType valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.CallStaticObjectMethod(java.lang.annotation.ElementType.staticClass, global::java.lang.annotation.ElementType._valueOf20953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.ElementType;
		}
		internal static global::MonoJavaBridge.FieldId _TYPE20954;
		public static global::java.lang.annotation.ElementType TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _TYPE20954)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FIELD20955;
		public static global::java.lang.annotation.ElementType FIELD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _FIELD20955)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _METHOD20956;
		public static global::java.lang.annotation.ElementType METHOD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _METHOD20956)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PARAMETER20957;
		public static global::java.lang.annotation.ElementType PARAMETER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _PARAMETER20957)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONSTRUCTOR20958;
		public static global::java.lang.annotation.ElementType CONSTRUCTOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _CONSTRUCTOR20958)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _LOCAL_VARIABLE20959;
		public static global::java.lang.annotation.ElementType LOCAL_VARIABLE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _LOCAL_VARIABLE20959)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANNOTATION_TYPE20960;
		public static global::java.lang.annotation.ElementType ANNOTATION_TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _ANNOTATION_TYPE20960)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PACKAGE20961;
		public static global::java.lang.annotation.ElementType PACKAGE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _PACKAGE20961)) as java.lang.annotation.ElementType;
			}
		}
		static ElementType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.ElementType.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/ElementType"));
			global::java.lang.annotation.ElementType._values20952 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "values", "()[Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._valueOf20953 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._TYPE20954 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "TYPE", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._FIELD20955 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "FIELD", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._METHOD20956 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "METHOD", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._PARAMETER20957 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "PARAMETER", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._CONSTRUCTOR20958 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "CONSTRUCTOR", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._LOCAL_VARIABLE20959 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "LOCAL_VARIABLE", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._ANNOTATION_TYPE20960 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "ANNOTATION_TYPE", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._PACKAGE20961 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "PACKAGE", "Ljava/lang/annotation/ElementType;");
		}
		internal static void InitJNI()
		{
		}
	}
}
