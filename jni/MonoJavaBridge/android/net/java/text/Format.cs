namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Format : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Format() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.Format), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Format(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Field : java.text.AttributedCharacterIterator_Attribute
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Field() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.Format.Field), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::java.text.Format.Field(@__env); 
				} 
			} 
			protected Field(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Field12606; 
			protected Field(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(java.text.Format.Field.staticClass, global::java.text.Format.Field._Field12606, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::java.text.Format.Field.staticClass = @__class; 
				global::java.text.Format.Field._Field12606 = @__env.GetMethodID(global::java.text.Format.Field.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone12607; 
		public virtual global::java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.Format._clone12607)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.Format.staticClass, global::java.text.Format._clone12607)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format12608; 
		public virtual global::java.lang.String format(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.Format._format12608, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.Format.staticClass, global::java.text.Format._format12608, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format12609; 
		public abstract global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _parseObject12610; 
		public virtual global::java.lang.Object parseObject(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.Format._parseObject12610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.Format.staticClass, global::java.text.Format._parseObject12610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseObject12611; 
		public abstract global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _formatToCharacterIterator12612; 
		public virtual global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.text.AttributedCharacterIterator>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.Format._formatToCharacterIterator12612, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.text.AttributedCharacterIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.Format.staticClass, global::java.text.Format._formatToCharacterIterator12612, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Format12613; 
		protected Format()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.text.Format.staticClass, global::java.text.Format._Format12613, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.text.Format.staticClass = @__class; 
			global::java.text.Format._clone12607 = @__env.GetMethodID(global::java.text.Format.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.text.Format._format12608 = @__env.GetMethodID(global::java.text.Format.staticClass, "format", "(Ljava/lang/Object;)Ljava/lang/String;"); 
			global::java.text.Format._format12609 = @__env.GetMethodID(global::java.text.Format.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"); 
			global::java.text.Format._parseObject12610 = @__env.GetMethodID(global::java.text.Format.staticClass, "parseObject", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::java.text.Format._parseObject12611 = @__env.GetMethodID(global::java.text.Format.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;"); 
			global::java.text.Format._formatToCharacterIterator12612 = @__env.GetMethodID(global::java.text.Format.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;"); 
			global::java.text.Format._Format12613 = @__env.GetMethodID(global::java.text.Format.staticClass, "<init>", "()V"); 
		} 
	} 
} 
