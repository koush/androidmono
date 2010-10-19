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
		internal static global::MonoJavaBridge.MethodId _equals19303;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._equals19303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._equals19303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19304;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._toString19304)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._toString19304)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19305;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._hashCode19305);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._hashCode19305);
		}
		protected new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName19306;
		protected virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._getName19306)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._getName19306)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readResolve19307;
		protected virtual global::java.lang.Object readResolve() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute._readResolve19307)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._readResolve19307)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _AttributedCharacterIterator_Attribute19308;
		protected AttributedCharacterIterator_Attribute(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute19308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _LANGUAGE19309;
		public static global::java.text.AttributedCharacterIterator_Attribute LANGUAGE
		{
			get
			{
				return default(global::java.text.AttributedCharacterIterator_Attribute);
			}
		}
		internal static global::MonoJavaBridge.FieldId _READING19310;
		public static global::java.text.AttributedCharacterIterator_Attribute READING
		{
			get
			{
				return default(global::java.text.AttributedCharacterIterator_Attribute);
			}
		}
		internal static global::MonoJavaBridge.FieldId _INPUT_METHOD_SEGMENT19311;
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
			global::java.text.AttributedCharacterIterator_Attribute._equals19303 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.AttributedCharacterIterator_Attribute._toString19304 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._hashCode19305 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "hashCode", "()I");
			global::java.text.AttributedCharacterIterator_Attribute._getName19306 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "getName", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._readResolve19307 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "readResolve", "()Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute19308 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
