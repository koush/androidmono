namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AttributedCharacterIterator_Attribute : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AttributedCharacterIterator_Attribute()
		{
			InitJNI();
		}
		protected AttributedCharacterIterator_Attribute(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25041;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._equals25041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._equals25041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25042;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._toString25042)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._toString25042)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25043;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._hashCode25043);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._hashCode25043);
		}
		protected new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName25044;
		protected virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._getName25044)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._getName25044)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readResolve25045;
		protected virtual global::java.lang.Object readResolve() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._readResolve25045)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._readResolve25045)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _AttributedCharacterIterator_Attribute25046;
		protected AttributedCharacterIterator_Attribute(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute25046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _LANGUAGE25047;
		public static global::java.text.AttributedCharacterIterator_Attribute LANGUAGE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.AttributedCharacterIterator_Attribute.staticClass, _LANGUAGE25047)) as java.text.AttributedCharacterIterator_Attribute;
			}
		}
		internal static global::MonoJavaBridge.FieldId _READING25048;
		public static global::java.text.AttributedCharacterIterator_Attribute READING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.AttributedCharacterIterator_Attribute.staticClass, _READING25048)) as java.text.AttributedCharacterIterator_Attribute;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INPUT_METHOD_SEGMENT25049;
		public static global::java.text.AttributedCharacterIterator_Attribute INPUT_METHOD_SEGMENT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.AttributedCharacterIterator_Attribute.staticClass, _INPUT_METHOD_SEGMENT25049)) as java.text.AttributedCharacterIterator_Attribute;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedCharacterIterator_Attribute.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedCharacterIterator_Attribute"));
			global::java.text.AttributedCharacterIterator_Attribute._equals25041 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.AttributedCharacterIterator_Attribute._toString25042 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._hashCode25043 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "hashCode", "()I");
			global::java.text.AttributedCharacterIterator_Attribute._getName25044 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "getName", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._readResolve25045 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "readResolve", "()Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute25046 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.AttributedCharacterIterator_Attribute._LANGUAGE25047 = @__env.GetStaticFieldIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "LANGUAGE", "Ljava/text/AttributedCharacterIterator$Attribute;");
			global::java.text.AttributedCharacterIterator_Attribute._READING25048 = @__env.GetStaticFieldIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "READING", "Ljava/text/AttributedCharacterIterator$Attribute;");
			global::java.text.AttributedCharacterIterator_Attribute._INPUT_METHOD_SEGMENT25049 = @__env.GetStaticFieldIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "INPUT_METHOD_SEGMENT", "Ljava/text/AttributedCharacterIterator$Attribute;");
		}
	}
}
