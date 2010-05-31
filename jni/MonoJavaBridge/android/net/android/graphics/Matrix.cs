namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Matrix : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Matrix() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Matrix), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.Matrix(@__env); 
			} 
		} 
		protected Matrix(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class ScaleToFit : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static ScaleToFit() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Matrix.ScaleToFit), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Matrix.ScaleToFit(@__env); 
				} 
			} 
			internal ScaleToFit(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2959; 
			public static global::android.graphics.Matrix.ScaleToFit valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix.ScaleToFit>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._valueOf2959, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2960; 
			public static global::android.graphics.Matrix.ScaleToFit[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._values2960)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CENTER2961; 
			public static global::android.graphics.Matrix.ScaleToFit CENTER
			{ 
				get 
				{ 
					return default(global::android.graphics.Matrix.ScaleToFit); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _END2962; 
			public static global::android.graphics.Matrix.ScaleToFit END
			{ 
				get 
				{ 
					return default(global::android.graphics.Matrix.ScaleToFit); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FILL2963; 
			public static global::android.graphics.Matrix.ScaleToFit FILL
			{ 
				get 
				{ 
					return default(global::android.graphics.Matrix.ScaleToFit); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _START2964; 
			public static global::android.graphics.Matrix.ScaleToFit START
			{ 
				get 
				{ 
					return default(global::android.graphics.Matrix.ScaleToFit); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Matrix.ScaleToFit.staticClass = @__class; 
				global::android.graphics.Matrix.ScaleToFit._valueOf2959 = @__env.GetStaticMethodID(global::android.graphics.Matrix.ScaleToFit.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Matrix$ScaleToFit;"); 
				global::android.graphics.Matrix.ScaleToFit._values2960 = @__env.GetStaticMethodID(global::android.graphics.Matrix.ScaleToFit.staticClass, "values", "()[Landroid/graphics/Matrix/ScaleToFit;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals2965; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._equals2965, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._equals2965, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString2966; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Matrix._toString2966)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._toString2966)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set2967; 
		public virtual void set(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._set2967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._set2967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2968; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._reset2968); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._reset2968); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toShortString2969; 
		public virtual global::java.lang.String toShortString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Matrix._toShortString2969)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._toShortString2969)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValues2970; 
		public virtual void getValues(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._getValues2970, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._getValues2970, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isIdentity2971; 
		public virtual bool isIdentity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._isIdentity2971); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._isIdentity2971); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rectStaysRect2972; 
		public virtual bool rectStaysRect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._rectStaysRect2972); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._rectStaysRect2972); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTranslate2973; 
		public virtual void setTranslate(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setTranslate2973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setTranslate2973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScale2974; 
		public virtual void setScale(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setScale2974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setScale2974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScale2975; 
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setScale2975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setScale2975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRotate2976; 
		public virtual void setRotate(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setRotate2976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRotate2976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRotate2977; 
		public virtual void setRotate(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setRotate2977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRotate2977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSinCos2978; 
		public virtual void setSinCos(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setSinCos2978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSinCos2978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSinCos2979; 
		public virtual void setSinCos(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setSinCos2979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSinCos2979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSkew2980; 
		public virtual void setSkew(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setSkew2980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSkew2980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSkew2981; 
		public virtual void setSkew(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setSkew2981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setSkew2981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setConcat2982; 
		public virtual bool setConcat(android.graphics.Matrix arg0, android.graphics.Matrix arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._setConcat2982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setConcat2982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preTranslate2983; 
		public virtual bool preTranslate(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preTranslate2983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preTranslate2983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preScale2984; 
		public virtual bool preScale(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preScale2984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preScale2984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preScale2985; 
		public virtual bool preScale(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preScale2985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preScale2985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preRotate2986; 
		public virtual bool preRotate(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preRotate2986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preRotate2986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preRotate2987; 
		public virtual bool preRotate(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preRotate2987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preRotate2987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preSkew2988; 
		public virtual bool preSkew(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preSkew2988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preSkew2988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preSkew2989; 
		public virtual bool preSkew(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preSkew2989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preSkew2989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preConcat2990; 
		public virtual bool preConcat(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._preConcat2990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._preConcat2990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postTranslate2991; 
		public virtual bool postTranslate(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postTranslate2991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postTranslate2991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postScale2992; 
		public virtual bool postScale(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postScale2992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postScale2992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postScale2993; 
		public virtual bool postScale(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postScale2993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postScale2993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postRotate2994; 
		public virtual bool postRotate(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postRotate2994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postRotate2994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postRotate2995; 
		public virtual bool postRotate(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postRotate2995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postRotate2995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postSkew2996; 
		public virtual bool postSkew(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postSkew2996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postSkew2996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postSkew2997; 
		public virtual bool postSkew(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postSkew2997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postSkew2997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postConcat2998; 
		public virtual bool postConcat(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._postConcat2998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._postConcat2998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRectToRect2999; 
		public virtual bool setRectToRect(android.graphics.RectF arg0, android.graphics.RectF arg1, android.graphics.Matrix.ScaleToFit arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._setRectToRect2999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setRectToRect2999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPolyToPoly3000; 
		public virtual bool setPolyToPoly(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._setPolyToPoly3000, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setPolyToPoly3000, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invert3001; 
		public virtual bool invert(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._invert3001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._invert3001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapPoints3002; 
		public virtual void mapPoints(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapPoints3002, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints3002, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapPoints3003; 
		public virtual void mapPoints(float[] arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapPoints3003, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints3003, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapPoints3004; 
		public virtual void mapPoints(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapPoints3004, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapPoints3004, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapVectors3005; 
		public virtual void mapVectors(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapVectors3005, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors3005, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapVectors3006; 
		public virtual void mapVectors(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapVectors3006, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors3006, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapVectors3007; 
		public virtual void mapVectors(float[] arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._mapVectors3007, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapVectors3007, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapRect3008; 
		public virtual bool mapRect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._mapRect3008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRect3008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapRect3009; 
		public virtual bool mapRect(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Matrix._mapRect3009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRect3009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapRadius3010; 
		public virtual float mapRadius(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.graphics.Matrix._mapRadius3010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._mapRadius3010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setValues3011; 
		public virtual void setValues(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Matrix._setValues3011, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Matrix.staticClass, global::android.graphics.Matrix._setValues3011, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Matrix3012; 
		public Matrix()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._Matrix3012, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Matrix3013; 
		public Matrix(android.graphics.Matrix arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._Matrix3013, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int MSCALE_X
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int MSKEW_X
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int MTRANS_X
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int MSKEW_Y
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int MSCALE_Y
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int MTRANS_Y
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int MPERSP_0
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		public static int MPERSP_1
		{ 
			get 
			{ 
				return 7; 
			} 
		} 
		public static int MPERSP_2
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Matrix.staticClass = @__class; 
			global::android.graphics.Matrix._equals2965 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.graphics.Matrix._toString2966 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.graphics.Matrix._set2967 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "set", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Matrix._reset2968 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "reset", "()V"); 
			global::android.graphics.Matrix._toShortString2969 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "toShortString", "()Ljava/lang/String;"); 
			global::android.graphics.Matrix._getValues2970 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "getValues", "([F)V"); 
			global::android.graphics.Matrix._isIdentity2971 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "isIdentity", "()Z"); 
			global::android.graphics.Matrix._rectStaysRect2972 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "rectStaysRect", "()Z"); 
			global::android.graphics.Matrix._setTranslate2973 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setTranslate", "(FF)V"); 
			global::android.graphics.Matrix._setScale2974 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setScale", "(FF)V"); 
			global::android.graphics.Matrix._setScale2975 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setScale", "(FFFF)V"); 
			global::android.graphics.Matrix._setRotate2976 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setRotate", "(FFF)V"); 
			global::android.graphics.Matrix._setRotate2977 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setRotate", "(F)V"); 
			global::android.graphics.Matrix._setSinCos2978 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSinCos", "(FFFF)V"); 
			global::android.graphics.Matrix._setSinCos2979 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSinCos", "(FF)V"); 
			global::android.graphics.Matrix._setSkew2980 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSkew", "(FFFF)V"); 
			global::android.graphics.Matrix._setSkew2981 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSkew", "(FF)V"); 
			global::android.graphics.Matrix._setConcat2982 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setConcat", "(Landroid/graphics/Matrix;Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Matrix._preTranslate2983 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preTranslate", "(FF)Z"); 
			global::android.graphics.Matrix._preScale2984 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preScale", "(FFFF)Z"); 
			global::android.graphics.Matrix._preScale2985 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preScale", "(FF)Z"); 
			global::android.graphics.Matrix._preRotate2986 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preRotate", "(FFF)Z"); 
			global::android.graphics.Matrix._preRotate2987 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preRotate", "(F)Z"); 
			global::android.graphics.Matrix._preSkew2988 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preSkew", "(FF)Z"); 
			global::android.graphics.Matrix._preSkew2989 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preSkew", "(FFFF)Z"); 
			global::android.graphics.Matrix._preConcat2990 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preConcat", "(Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Matrix._postTranslate2991 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postTranslate", "(FF)Z"); 
			global::android.graphics.Matrix._postScale2992 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postScale", "(FFFF)Z"); 
			global::android.graphics.Matrix._postScale2993 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postScale", "(FF)Z"); 
			global::android.graphics.Matrix._postRotate2994 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postRotate", "(FFF)Z"); 
			global::android.graphics.Matrix._postRotate2995 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postRotate", "(F)Z"); 
			global::android.graphics.Matrix._postSkew2996 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postSkew", "(FFFF)Z"); 
			global::android.graphics.Matrix._postSkew2997 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postSkew", "(FF)Z"); 
			global::android.graphics.Matrix._postConcat2998 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postConcat", "(Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Matrix._setRectToRect2999 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setRectToRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;Landroid/graphics/Matrix$ScaleToFit;)Z"); 
			global::android.graphics.Matrix._setPolyToPoly3000 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setPolyToPoly", "([FI[FII)Z"); 
			global::android.graphics.Matrix._invert3001 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "invert", "(Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Matrix._mapPoints3002 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapPoints", "([FI[FII)V"); 
			global::android.graphics.Matrix._mapPoints3003 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapPoints", "([F[F)V"); 
			global::android.graphics.Matrix._mapPoints3004 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapPoints", "([F)V"); 
			global::android.graphics.Matrix._mapVectors3005 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapVectors", "([FI[FII)V"); 
			global::android.graphics.Matrix._mapVectors3006 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapVectors", "([F)V"); 
			global::android.graphics.Matrix._mapVectors3007 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapVectors", "([F[F)V"); 
			global::android.graphics.Matrix._mapRect3008 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z"); 
			global::android.graphics.Matrix._mapRect3009 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;)Z"); 
			global::android.graphics.Matrix._mapRadius3010 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapRadius", "(F)F"); 
			global::android.graphics.Matrix._setValues3011 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setValues", "([F)V"); 
			global::android.graphics.Matrix._Matrix3012 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "<init>", "()V"); 
			global::android.graphics.Matrix._Matrix3013 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "<init>", "(Landroid/graphics/Matrix;)V"); 
		} 
	} 
} 
