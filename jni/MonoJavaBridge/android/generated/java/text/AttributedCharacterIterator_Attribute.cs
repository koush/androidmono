namespace java.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AttributedCharacterIterator_Attribute : java.lang.Object, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static AttributedCharacterIterator_Attribute()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.AttributedCharacterIterator_Attribute), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.text.AttributedCharacterIterator_Attribute(@__env);
			}
		}
		protected AttributedCharacterIterator_Attribute(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13356;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.text.AttributedCharacterIterator_Attribute._equals13356, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._equals13356, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13357;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.AttributedCharacterIterator_Attribute._toString13357));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._toString13357));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13358;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.AttributedCharacterIterator_Attribute._hashCode13358);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._hashCode13358);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName13359;
		protected virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.AttributedCharacterIterator_Attribute._getName13359));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._getName13359));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readResolve13360;
		protected virtual global::java.lang.Object readResolve() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.AttributedCharacterIterator_Attribute._readResolve13360));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._readResolve13360));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AttributedCharacterIterator_Attribute13361;
		protected AttributedCharacterIterator_Attribute(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.text.AttributedCharacterIterator_Attribute.staticClass, global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute13361, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _LANGUAGE13362;
		public static global::java.text.AttributedCharacterIterator_Attribute LANGUAGE
		{
			get
			{
				return default(global::java.text.AttributedCharacterIterator_Attribute);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _READING13363;
		public static global::java.text.AttributedCharacterIterator_Attribute READING
		{
			get
			{
				return default(global::java.text.AttributedCharacterIterator_Attribute);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _INPUT_METHOD_SEGMENT13364;
		public static global::java.text.AttributedCharacterIterator_Attribute INPUT_METHOD_SEGMENT
		{
			get
			{
				return default(global::java.text.AttributedCharacterIterator_Attribute);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.text.AttributedCharacterIterator_Attribute.staticClass = @__class;
			global::java.text.AttributedCharacterIterator_Attribute._equals13356 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.AttributedCharacterIterator_Attribute._toString13357 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._hashCode13358 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "hashCode", "()I");
			global::java.text.AttributedCharacterIterator_Attribute._getName13359 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "getName", "()Ljava/lang/String;");
			global::java.text.AttributedCharacterIterator_Attribute._readResolve13360 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "readResolve", "()Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute13361 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
