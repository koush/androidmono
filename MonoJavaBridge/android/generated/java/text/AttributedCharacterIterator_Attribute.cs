namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AttributedCharacterIterator_Attribute : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AttributedCharacterIterator_Attribute(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25160;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._equals25160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25161;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._toString25161)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25162;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._hashCode25162);
		}
		protected new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName25163;
		protected virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._getName25163)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readResolve25164;
		protected virtual global::java.lang.Object readResolve()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._readResolve25164)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _AttributedCharacterIterator_Attribute25165;
		protected AttributedCharacterIterator_Attribute(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute25165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _LANGUAGE25166;
		public static global::java.text.AttributedCharacterIterator_Attribute LANGUAGE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.AttributedCharacterIterator_Attribute.staticClass, _LANGUAGE25166)) as java.text.AttributedCharacterIterator_Attribute;
			}
		}
		internal static global::MonoJavaBridge.FieldId _READING25167;
		public static global::java.text.AttributedCharacterIterator_Attribute READING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.AttributedCharacterIterator_Attribute.staticClass, _READING25167)) as java.text.AttributedCharacterIterator_Attribute;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INPUT_METHOD_SEGMENT25168;
		public static global::java.text.AttributedCharacterIterator_Attribute INPUT_METHOD_SEGMENT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.AttributedCharacterIterator_Attribute.staticClass, _INPUT_METHOD_SEGMENT25168)) as java.text.AttributedCharacterIterator_Attribute;
			}
		}
		static AttributedCharacterIterator_Attribute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedCharacterIterator_Attribute.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedCharacterIterator$Attribute"));
			global::java.text.AttributedCharacterIterator_Attribute._equals25160 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.AttributedCharacterIterator_Attribute._toString25161 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._hashCode25162 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "hashCode", "()I");
			global::java.text.AttributedCharacterIterator_Attribute._getName25163 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "getName", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._readResolve25164 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "readResolve", "()Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute25165 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.AttributedCharacterIterator_Attribute._LANGUAGE25166 = @__env.GetStaticFieldIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "LANGUAGE", "Ljava/text/AttributedCharacterIterator$Attribute;");
			global::java.text.AttributedCharacterIterator_Attribute._READING25167 = @__env.GetStaticFieldIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "READING", "Ljava/text/AttributedCharacterIterator$Attribute;");
			global::java.text.AttributedCharacterIterator_Attribute._INPUT_METHOD_SEGMENT25168 = @__env.GetStaticFieldIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "INPUT_METHOD_SEGMENT", "Ljava/text/AttributedCharacterIterator$Attribute;");
		}
		internal static void InitJNI()
		{
		}
	}
}
