namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AttributedCharacterIterator_Attribute : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AttributedCharacterIterator_Attribute(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.AttributedCharacterIterator_Attribute._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, "toString", "()Ljava/lang/String;", ref global::java.text.AttributedCharacterIterator_Attribute._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, "hashCode", "()I", ref global::java.text.AttributedCharacterIterator_Attribute._m2);
		}
		protected new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, "getName", "()Ljava/lang/String;", ref global::java.text.AttributedCharacterIterator_Attribute._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual global::java.lang.Object readResolve()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, "readResolve", "()Ljava/lang/Object;", ref global::java.text.AttributedCharacterIterator_Attribute._m4) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected AttributedCharacterIterator_Attribute(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.AttributedCharacterIterator_Attribute._m5.native == global::System.IntPtr.Zero)
				global::java.text.AttributedCharacterIterator_Attribute._m5 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _LANGUAGE6678;
		public static global::java.text.AttributedCharacterIterator_Attribute LANGUAGE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.AttributedCharacterIterator_Attribute.staticClass, _LANGUAGE6678)) as java.text.AttributedCharacterIterator_Attribute;
			}
		}
		internal static global::MonoJavaBridge.FieldId _READING6679;
		public static global::java.text.AttributedCharacterIterator_Attribute READING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.AttributedCharacterIterator_Attribute.staticClass, _READING6679)) as java.text.AttributedCharacterIterator_Attribute;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INPUT_METHOD_SEGMENT6680;
		public static global::java.text.AttributedCharacterIterator_Attribute INPUT_METHOD_SEGMENT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.AttributedCharacterIterator_Attribute.staticClass, _INPUT_METHOD_SEGMENT6680)) as java.text.AttributedCharacterIterator_Attribute;
			}
		}
		static AttributedCharacterIterator_Attribute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedCharacterIterator_Attribute.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedCharacterIterator$Attribute"));
			global::java.text.AttributedCharacterIterator_Attribute._LANGUAGE6678 = @__env.GetStaticFieldIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "LANGUAGE", "Ljava/text/AttributedCharacterIterator$Attribute;");
			global::java.text.AttributedCharacterIterator_Attribute._READING6679 = @__env.GetStaticFieldIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "READING", "Ljava/text/AttributedCharacterIterator$Attribute;");
			global::java.text.AttributedCharacterIterator_Attribute._INPUT_METHOD_SEGMENT6680 = @__env.GetStaticFieldIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "INPUT_METHOD_SEGMENT", "Ljava/text/AttributedCharacterIterator$Attribute;");
		}
	}
}
