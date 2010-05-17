namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Transformation : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Transformation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.Transformation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.animation.Transformation(@__env); 
			} 
		} 
		protected Transformation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear8361; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				@__env.CallVoidMethod(this, _clear8361); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Transformation.staticClass, _clear8361); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString8362; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString8362)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.Transformation.staticClass, _toString8362)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set8363; 
		public virtual void set(android.view.animation.Transformation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				@__env.CallVoidMethod(this, _set8363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Transformation.staticClass, _set8363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compose8364; 
		public virtual void compose(android.view.animation.Transformation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				@__env.CallVoidMethod(this, _compose8364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Transformation.staticClass, _compose8364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha8365; 
		public virtual void setAlpha(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				@__env.CallVoidMethod(this, _setAlpha8365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Transformation.staticClass, _setAlpha8365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toShortString8366; 
		public virtual java.lang.String toShortString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toShortString8366)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.Transformation.staticClass, _toShortString8366)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix8367; 
		public virtual android.graphics.Matrix getMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallObjectMethodPtr(this, _getMatrix8367)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.Transformation.staticClass, _getMatrix8367)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformationType8368; 
		public virtual int getTransformationType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				return @__env.CallIntMethod(this, _getTransformationType8368); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.animation.Transformation.staticClass, _getTransformationType8368); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTransformationType8369; 
		public virtual void setTransformationType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				@__env.CallVoidMethod(this, _setTransformationType8369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Transformation.staticClass, _setTransformationType8369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlpha8370; 
		public virtual float getAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Transformation)) 
				return @__env.CallFloatMethod(this, _getAlpha8370); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.animation.Transformation.staticClass, _getAlpha8370); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Transformation8371; 
		public Transformation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.Transformation.staticClass, _Transformation8371, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_IDENTITY8372; 
		public static int TYPE_IDENTITY
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_ALPHA8373; 
		public static int TYPE_ALPHA
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_MATRIX8374; 
		public static int TYPE_MATRIX
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_BOTH8375; 
		public static int TYPE_BOTH
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.Transformation.staticClass = @__class; 
			global::android.view.animation.Transformation._clear8361 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "clear", "()V"); 
			global::android.view.animation.Transformation._toString8362 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.animation.Transformation._set8363 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "set", "(Landroid/view/animation/Transformation;)V"); 
			global::android.view.animation.Transformation._compose8364 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "compose", "(Landroid/view/animation/Transformation;)V"); 
			global::android.view.animation.Transformation._setAlpha8365 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "setAlpha", "(F)V"); 
			global::android.view.animation.Transformation._toShortString8366 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "toShortString", "()Ljava/lang/String;"); 
			global::android.view.animation.Transformation._getMatrix8367 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "getMatrix", "()Landroid/graphics/Matrix;"); 
			global::android.view.animation.Transformation._getTransformationType8368 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "getTransformationType", "()I"); 
			global::android.view.animation.Transformation._setTransformationType8369 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "setTransformationType", "(I)V"); 
			global::android.view.animation.Transformation._getAlpha8370 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "getAlpha", "()F"); 
			global::android.view.animation.Transformation._Transformation8371 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "<init>", "()V"); 
		} 
	} 
} 
