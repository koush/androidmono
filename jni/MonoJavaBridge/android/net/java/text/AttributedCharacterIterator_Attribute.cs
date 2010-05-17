namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AttributedCharacterIterator_Attribute : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static AttributedCharacterIterator_Attribute() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.text.AttributedCharacterIterator_Attribute), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11649; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.AttributedCharacterIterator_Attribute)) 
				return @__env.CallIntMethod(this, _hashCode11649); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.AttributedCharacterIterator_Attribute.staticClass, _hashCode11649); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11650; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.AttributedCharacterIterator_Attribute)) 
				return @__env.CallBooleanMethod(this, _equals11650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.text.AttributedCharacterIterator_Attribute.staticClass, _equals11650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11651; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.AttributedCharacterIterator_Attribute)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11651)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.AttributedCharacterIterator_Attribute.staticClass, _toString11651)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName11652; 
		protected virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.AttributedCharacterIterator_Attribute)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName11652)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.AttributedCharacterIterator_Attribute.staticClass, _getName11652)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readResolve11653; 
		protected virtual java.lang.Object readResolve() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.AttributedCharacterIterator_Attribute)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _readResolve11653)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.AttributedCharacterIterator_Attribute.staticClass, _readResolve11653)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AttributedCharacterIterator_Attribute11654; 
		protected AttributedCharacterIterator_Attribute(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.text.AttributedCharacterIterator_Attribute.staticClass, _AttributedCharacterIterator_Attribute11654, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _LANGUAGE11655; 
		public static java.text.AttributedCharacterIterator_Attribute LANGUAGE
		{ 
			get 
			{ 
				return default(java.text.AttributedCharacterIterator_Attribute); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _READING11656; 
		public static java.text.AttributedCharacterIterator_Attribute READING
		{ 
			get 
			{ 
				return default(java.text.AttributedCharacterIterator_Attribute); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _INPUT_METHOD_SEGMENT11657; 
		public static java.text.AttributedCharacterIterator_Attribute INPUT_METHOD_SEGMENT
		{ 
			get 
			{ 
				return default(java.text.AttributedCharacterIterator_Attribute); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.text.AttributedCharacterIterator_Attribute.staticClass = @__class; 
			global::java.text.AttributedCharacterIterator_Attribute._hashCode11649 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "hashCode", "()I"); 
			global::java.text.AttributedCharacterIterator_Attribute._equals11650 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.text.AttributedCharacterIterator_Attribute._toString11651 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.text.AttributedCharacterIterator_Attribute._getName11652 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "getName", "()Ljava/lang/String;"); 
			global::java.text.AttributedCharacterIterator_Attribute._readResolve11653 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "readResolve", "()Ljava/lang/Object;"); 
			global::java.text.AttributedCharacterIterator_Attribute._AttributedCharacterIterator_Attribute11654 = @__env.GetMethodID(global::java.text.AttributedCharacterIterator_Attribute.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
