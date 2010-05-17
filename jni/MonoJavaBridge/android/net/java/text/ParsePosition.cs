namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ParsePosition : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ParsePosition() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.text.ParsePosition), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.text.ParsePosition(@__env); 
			} 
		} 
		protected ParsePosition(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11744; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.ParsePosition)) 
				return @__env.CallIntMethod(this, _hashCode11744); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.ParsePosition.staticClass, _hashCode11744); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11745; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.ParsePosition)) 
				return @__env.CallBooleanMethod(this, _equals11745, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.text.ParsePosition.staticClass, _equals11745, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11746; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.ParsePosition)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11746)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.ParsePosition.staticClass, _toString11746)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndex11747; 
		public virtual int getIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.ParsePosition)) 
				return @__env.CallIntMethod(this, _getIndex11747); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.ParsePosition.staticClass, _getIndex11747); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndex11748; 
		public virtual void setIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.ParsePosition)) 
				@__env.CallVoidMethod(this, _setIndex11748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.ParsePosition.staticClass, _setIndex11748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setErrorIndex11749; 
		public virtual void setErrorIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.ParsePosition)) 
				@__env.CallVoidMethod(this, _setErrorIndex11749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.ParsePosition.staticClass, _setErrorIndex11749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getErrorIndex11750; 
		public virtual int getErrorIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.ParsePosition)) 
				return @__env.CallIntMethod(this, _getErrorIndex11750); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.ParsePosition.staticClass, _getErrorIndex11750); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ParsePosition11751; 
		public ParsePosition(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.text.ParsePosition.staticClass, _ParsePosition11751, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.text.ParsePosition.staticClass = @__class; 
			global::java.text.ParsePosition._hashCode11744 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "hashCode", "()I"); 
			global::java.text.ParsePosition._equals11745 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.text.ParsePosition._toString11746 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.text.ParsePosition._getIndex11747 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "getIndex", "()I"); 
			global::java.text.ParsePosition._setIndex11748 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "setIndex", "(I)V"); 
			global::java.text.ParsePosition._setErrorIndex11749 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "setErrorIndex", "(I)V"); 
			global::java.text.ParsePosition._getErrorIndex11750 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "getErrorIndex", "()I"); 
			global::java.text.ParsePosition._ParsePosition11751 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
