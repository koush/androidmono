namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class FieldPosition : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static FieldPosition() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.text.FieldPosition), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.text.FieldPosition(@__env); 
			} 
		} 
		protected FieldPosition(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11686; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.FieldPosition)) 
				return @__env.CallIntMethod(this, _hashCode11686); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.FieldPosition.staticClass, _hashCode11686); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11687; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.FieldPosition)) 
				return @__env.CallBooleanMethod(this, _equals11687, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.text.FieldPosition.staticClass, _equals11687, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11688; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.FieldPosition)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11688)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.FieldPosition.staticClass, _toString11688)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getField11689; 
		public virtual int getField() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.FieldPosition)) 
				return @__env.CallIntMethod(this, _getField11689); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.FieldPosition.staticClass, _getField11689); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBeginIndex11690; 
		public virtual int getBeginIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.FieldPosition)) 
				return @__env.CallIntMethod(this, _getBeginIndex11690); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.FieldPosition.staticClass, _getBeginIndex11690); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEndIndex11691; 
		public virtual int getEndIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.FieldPosition)) 
				return @__env.CallIntMethod(this, _getEndIndex11691); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.FieldPosition.staticClass, _getEndIndex11691); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFieldAttribute11692; 
		public virtual java.text.Format.Field getFieldAttribute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.FieldPosition)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.Format.Field>(@__env, @__env.CallObjectMethodPtr(this, _getFieldAttribute11692)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.Format.Field>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.FieldPosition.staticClass, _getFieldAttribute11692)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBeginIndex11693; 
		public virtual void setBeginIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.FieldPosition)) 
				@__env.CallVoidMethod(this, _setBeginIndex11693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.FieldPosition.staticClass, _setBeginIndex11693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEndIndex11694; 
		public virtual void setEndIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.FieldPosition)) 
				@__env.CallVoidMethod(this, _setEndIndex11694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.FieldPosition.staticClass, _setEndIndex11694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FieldPosition11695; 
		public FieldPosition(java.text.Format.Field arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.text.FieldPosition.staticClass, _FieldPosition11695, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FieldPosition11696; 
		public FieldPosition(java.text.Format.Field arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.text.FieldPosition.staticClass, _FieldPosition11696, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FieldPosition11697; 
		public FieldPosition(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.text.FieldPosition.staticClass, _FieldPosition11697, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.text.FieldPosition.staticClass = @__class; 
			global::java.text.FieldPosition._hashCode11686 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "hashCode", "()I"); 
			global::java.text.FieldPosition._equals11687 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.text.FieldPosition._toString11688 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.text.FieldPosition._getField11689 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "getField", "()I"); 
			global::java.text.FieldPosition._getBeginIndex11690 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "getBeginIndex", "()I"); 
			global::java.text.FieldPosition._getEndIndex11691 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "getEndIndex", "()I"); 
			global::java.text.FieldPosition._getFieldAttribute11692 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "getFieldAttribute", "()Ljava/text/Format$Field;"); 
			global::java.text.FieldPosition._setBeginIndex11693 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "setBeginIndex", "(I)V"); 
			global::java.text.FieldPosition._setEndIndex11694 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "setEndIndex", "(I)V"); 
			global::java.text.FieldPosition._FieldPosition11695 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;)V"); 
			global::java.text.FieldPosition._FieldPosition11696 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;I)V"); 
			global::java.text.FieldPosition._FieldPosition11697 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
