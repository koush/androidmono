namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ElementType : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ElementType()
		{
			InitJNI();
		}
		internal ElementType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values20833;
		public static global::java.lang.annotation.ElementType[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.ElementType>(@__env.CallStaticObjectMethod(java.lang.annotation.ElementType.staticClass, global::java.lang.annotation.ElementType._values20833)) as java.lang.annotation.ElementType[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20834;
		public static global::java.lang.annotation.ElementType valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.CallStaticObjectMethod(java.lang.annotation.ElementType.staticClass, global::java.lang.annotation.ElementType._valueOf20834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.ElementType;
		}
		internal static global::MonoJavaBridge.FieldId _TYPE20835;
		public static global::java.lang.annotation.ElementType TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _TYPE20835)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FIELD20836;
		public static global::java.lang.annotation.ElementType FIELD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _FIELD20836)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _METHOD20837;
		public static global::java.lang.annotation.ElementType METHOD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _METHOD20837)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PARAMETER20838;
		public static global::java.lang.annotation.ElementType PARAMETER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _PARAMETER20838)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONSTRUCTOR20839;
		public static global::java.lang.annotation.ElementType CONSTRUCTOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _CONSTRUCTOR20839)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _LOCAL_VARIABLE20840;
		public static global::java.lang.annotation.ElementType LOCAL_VARIABLE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _LOCAL_VARIABLE20840)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANNOTATION_TYPE20841;
		public static global::java.lang.annotation.ElementType ANNOTATION_TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _ANNOTATION_TYPE20841)) as java.lang.annotation.ElementType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PACKAGE20842;
		public static global::java.lang.annotation.ElementType PACKAGE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.ElementType>(@__env.GetStaticObjectField(global::java.lang.annotation.ElementType.staticClass, _PACKAGE20842)) as java.lang.annotation.ElementType;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.ElementType.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/ElementType"));
			global::java.lang.annotation.ElementType._values20833 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "values", "()[Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._valueOf20834 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._TYPE20835 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "TYPE", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._FIELD20836 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "FIELD", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._METHOD20837 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "METHOD", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._PARAMETER20838 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "PARAMETER", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._CONSTRUCTOR20839 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "CONSTRUCTOR", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._LOCAL_VARIABLE20840 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "LOCAL_VARIABLE", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._ANNOTATION_TYPE20841 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "ANNOTATION_TYPE", "Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._PACKAGE20842 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "PACKAGE", "Ljava/lang/annotation/ElementType;");
		}
	}
}
