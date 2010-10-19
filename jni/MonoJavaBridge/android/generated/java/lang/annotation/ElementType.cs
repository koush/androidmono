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
		internal static global::MonoJavaBridge.MethodId _values15311;
		public static global::java.lang.annotation.ElementType[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.ElementType>(@__env.CallStaticObjectMethod(java.lang.annotation.ElementType.staticClass, global::java.lang.annotation.ElementType._values15311)) as java.lang.annotation.ElementType[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15312;
		public static global::java.lang.annotation.ElementType valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.annotation.ElementType.staticClass, global::java.lang.annotation.ElementType._valueOf15312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.ElementType;
		}
		internal static global::MonoJavaBridge.FieldId _TYPE15313;
		public static global::java.lang.annotation.ElementType TYPE
		{
			get
			{
				return default(global::java.lang.annotation.ElementType);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FIELD15314;
		public static global::java.lang.annotation.ElementType FIELD
		{
			get
			{
				return default(global::java.lang.annotation.ElementType);
			}
		}
		internal static global::MonoJavaBridge.FieldId _METHOD15315;
		public static global::java.lang.annotation.ElementType METHOD
		{
			get
			{
				return default(global::java.lang.annotation.ElementType);
			}
		}
		internal static global::MonoJavaBridge.FieldId _PARAMETER15316;
		public static global::java.lang.annotation.ElementType PARAMETER
		{
			get
			{
				return default(global::java.lang.annotation.ElementType);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONSTRUCTOR15317;
		public static global::java.lang.annotation.ElementType CONSTRUCTOR
		{
			get
			{
				return default(global::java.lang.annotation.ElementType);
			}
		}
		internal static global::MonoJavaBridge.FieldId _LOCAL_VARIABLE15318;
		public static global::java.lang.annotation.ElementType LOCAL_VARIABLE
		{
			get
			{
				return default(global::java.lang.annotation.ElementType);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANNOTATION_TYPE15319;
		public static global::java.lang.annotation.ElementType ANNOTATION_TYPE
		{
			get
			{
				return default(global::java.lang.annotation.ElementType);
			}
		}
		internal static global::MonoJavaBridge.FieldId _PACKAGE15320;
		public static global::java.lang.annotation.ElementType PACKAGE
		{
			get
			{
				return default(global::java.lang.annotation.ElementType);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.ElementType.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/ElementType"));
			global::java.lang.annotation.ElementType._values15311 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "values", "()[Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.ElementType._valueOf15312 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.ElementType.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/ElementType;");
		}
	}
}
