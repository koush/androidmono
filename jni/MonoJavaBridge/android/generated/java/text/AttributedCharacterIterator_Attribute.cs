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
		internal static global::MonoJavaBridge.MethodId _equals15029;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._equals15029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._equals15029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15030;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._toString15030)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._toString15030)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15031;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._hashCode15031);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._hashCode15031);
		}
		internal static global::MonoJavaBridge.MethodId _getName15032;
		protected virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._getName15032)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._getName15032)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readResolve15033;
		protected virtual global::java.lang.Object readResolve() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._readResolve15033)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._readResolve15033)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _AttributedCharacterIterator_Attribute15034;
		protected AttributedCharacterIterator_Attribute(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute15034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _LANGUAGE15035;
		public static global::java.text.AttributedCharacterIterator_Attribute LANGUAGE
		{
			get
			{
				return default(global::java.text.AttributedCharacterIterator_Attribute);
			}
		}
		internal static global::MonoJavaBridge.FieldId _READING15036;
		public static global::java.text.AttributedCharacterIterator_Attribute READING
		{
			get
			{
				return default(global::java.text.AttributedCharacterIterator_Attribute);
			}
		}
		internal static global::MonoJavaBridge.FieldId _INPUT_METHOD_SEGMENT15037;
		public static global::java.text.AttributedCharacterIterator_Attribute INPUT_METHOD_SEGMENT
		{
			get
			{
				return default(global::java.text.AttributedCharacterIterator_Attribute);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedCharacterIterator_Attribute.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedCharacterIterator_Attribute"));
			global::java.text.AttributedCharacterIterator_Attribute._equals15029 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.AttributedCharacterIterator_Attribute._toString15030 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._hashCode15031 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "hashCode", "()I");
			global::java.text.AttributedCharacterIterator_Attribute._getName15032 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "getName", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._readResolve15033 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "readResolve", "()Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute15034 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
