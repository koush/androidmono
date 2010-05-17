namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Matrix : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Matrix() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Matrix), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Matrix.ScaleToFit), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2759; 
			public static android.graphics.Matrix.ScaleToFit valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix.ScaleToFit>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Matrix.ScaleToFit.staticClass, _valueOf2759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2760; 
			public static android.graphics.Matrix.ScaleToFit[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Matrix.ScaleToFit.staticClass, _values2760)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CENTER2761; 
			public static android.graphics.Matrix.ScaleToFit CENTER
			{ 
				get 
				{ 
					return default(android.graphics.Matrix.ScaleToFit); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _END2762; 
			public static android.graphics.Matrix.ScaleToFit END
			{ 
				get 
				{ 
					return default(android.graphics.Matrix.ScaleToFit); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FILL2763; 
			public static android.graphics.Matrix.ScaleToFit FILL
			{ 
				get 
				{ 
					return default(android.graphics.Matrix.ScaleToFit); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _START2764; 
			public static android.graphics.Matrix.ScaleToFit START
			{ 
				get 
				{ 
					return default(android.graphics.Matrix.ScaleToFit); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Matrix.ScaleToFit.staticClass = @__class; 
				global::android.graphics.Matrix.ScaleToFit._valueOf2759 = @__env.GetStaticMethodID(global::android.graphics.Matrix.ScaleToFit.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Matrix$ScaleToFit;"); 
				global::android.graphics.Matrix.ScaleToFit._values2760 = @__env.GetStaticMethodID(global::android.graphics.Matrix.ScaleToFit.staticClass, "values", "()[Landroid/graphics/Matrix/ScaleToFit;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals2765; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _equals2765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _equals2765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString2766; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString2766)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Matrix.staticClass, _toString2766)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set2767; 
		public virtual void set(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _set2767, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _set2767, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2768; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _reset2768); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _reset2768); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toShortString2769; 
		public virtual java.lang.String toShortString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toShortString2769)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Matrix.staticClass, _toShortString2769)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValues2770; 
		public virtual void getValues(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _getValues2770, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _getValues2770, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isIdentity2771; 
		public virtual bool isIdentity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _isIdentity2771); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _isIdentity2771); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rectStaysRect2772; 
		public virtual bool rectStaysRect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _rectStaysRect2772); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _rectStaysRect2772); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTranslate2773; 
		public virtual void setTranslate(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setTranslate2773, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setTranslate2773, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScale2774; 
		public virtual void setScale(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setScale2774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setScale2774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScale2775; 
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setScale2775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setScale2775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRotate2776; 
		public virtual void setRotate(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setRotate2776, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setRotate2776, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRotate2777; 
		public virtual void setRotate(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setRotate2777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setRotate2777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSinCos2778; 
		public virtual void setSinCos(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setSinCos2778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setSinCos2778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSinCos2779; 
		public virtual void setSinCos(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setSinCos2779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setSinCos2779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSkew2780; 
		public virtual void setSkew(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setSkew2780, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setSkew2780, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSkew2781; 
		public virtual void setSkew(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setSkew2781, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setSkew2781, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setConcat2782; 
		public virtual bool setConcat(android.graphics.Matrix arg0, android.graphics.Matrix arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _setConcat2782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _setConcat2782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preTranslate2783; 
		public virtual bool preTranslate(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _preTranslate2783, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _preTranslate2783, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preScale2784; 
		public virtual bool preScale(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _preScale2784, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _preScale2784, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preScale2785; 
		public virtual bool preScale(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _preScale2785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _preScale2785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preRotate2786; 
		public virtual bool preRotate(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _preRotate2786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _preRotate2786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preRotate2787; 
		public virtual bool preRotate(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _preRotate2787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _preRotate2787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preSkew2788; 
		public virtual bool preSkew(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _preSkew2788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _preSkew2788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preSkew2789; 
		public virtual bool preSkew(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _preSkew2789, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _preSkew2789, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preConcat2790; 
		public virtual bool preConcat(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _preConcat2790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _preConcat2790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postTranslate2791; 
		public virtual bool postTranslate(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _postTranslate2791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _postTranslate2791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postScale2792; 
		public virtual bool postScale(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _postScale2792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _postScale2792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postScale2793; 
		public virtual bool postScale(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _postScale2793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _postScale2793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postRotate2794; 
		public virtual bool postRotate(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _postRotate2794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _postRotate2794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postRotate2795; 
		public virtual bool postRotate(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _postRotate2795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _postRotate2795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postSkew2796; 
		public virtual bool postSkew(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _postSkew2796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _postSkew2796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postSkew2797; 
		public virtual bool postSkew(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _postSkew2797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _postSkew2797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postConcat2798; 
		public virtual bool postConcat(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _postConcat2798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _postConcat2798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRectToRect2799; 
		public virtual bool setRectToRect(android.graphics.RectF arg0, android.graphics.RectF arg1, android.graphics.Matrix.ScaleToFit arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _setRectToRect2799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _setRectToRect2799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPolyToPoly2800; 
		public virtual bool setPolyToPoly(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _setPolyToPoly2800, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _setPolyToPoly2800, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invert2801; 
		public virtual bool invert(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _invert2801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _invert2801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapPoints2802; 
		public virtual void mapPoints(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _mapPoints2802, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _mapPoints2802, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapPoints2803; 
		public virtual void mapPoints(float[] arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _mapPoints2803, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _mapPoints2803, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapPoints2804; 
		public virtual void mapPoints(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _mapPoints2804, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _mapPoints2804, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapVectors2805; 
		public virtual void mapVectors(float[] arg0, int arg1, float[] arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _mapVectors2805, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _mapVectors2805, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapVectors2806; 
		public virtual void mapVectors(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _mapVectors2806, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _mapVectors2806, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapVectors2807; 
		public virtual void mapVectors(float[] arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _mapVectors2807, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _mapVectors2807, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapRect2808; 
		public virtual bool mapRect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _mapRect2808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _mapRect2808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapRect2809; 
		public virtual bool mapRect(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallBooleanMethod(this, _mapRect2809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Matrix.staticClass, _mapRect2809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mapRadius2810; 
		public virtual float mapRadius(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				return @__env.CallFloatMethod(this, _mapRadius2810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.Matrix.staticClass, _mapRadius2810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setValues2811; 
		public virtual void setValues(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Matrix)) 
				@__env.CallVoidMethod(this, _setValues2811, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Matrix.staticClass, _setValues2811, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Matrix2812; 
		public Matrix()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Matrix.staticClass, _Matrix2812, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Matrix2813; 
		public Matrix(android.graphics.Matrix arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Matrix.staticClass, _Matrix2813, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.graphics.Matrix._equals2765 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.graphics.Matrix._toString2766 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.graphics.Matrix._set2767 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "set", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Matrix._reset2768 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "reset", "()V"); 
			global::android.graphics.Matrix._toShortString2769 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "toShortString", "()Ljava/lang/String;"); 
			global::android.graphics.Matrix._getValues2770 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "getValues", "([F)V"); 
			global::android.graphics.Matrix._isIdentity2771 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "isIdentity", "()Z"); 
			global::android.graphics.Matrix._rectStaysRect2772 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "rectStaysRect", "()Z"); 
			global::android.graphics.Matrix._setTranslate2773 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setTranslate", "(FF)V"); 
			global::android.graphics.Matrix._setScale2774 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setScale", "(FF)V"); 
			global::android.graphics.Matrix._setScale2775 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setScale", "(FFFF)V"); 
			global::android.graphics.Matrix._setRotate2776 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setRotate", "(FFF)V"); 
			global::android.graphics.Matrix._setRotate2777 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setRotate", "(F)V"); 
			global::android.graphics.Matrix._setSinCos2778 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSinCos", "(FFFF)V"); 
			global::android.graphics.Matrix._setSinCos2779 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSinCos", "(FF)V"); 
			global::android.graphics.Matrix._setSkew2780 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSkew", "(FFFF)V"); 
			global::android.graphics.Matrix._setSkew2781 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setSkew", "(FF)V"); 
			global::android.graphics.Matrix._setConcat2782 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setConcat", "(Landroid/graphics/Matrix;Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Matrix._preTranslate2783 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preTranslate", "(FF)Z"); 
			global::android.graphics.Matrix._preScale2784 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preScale", "(FFFF)Z"); 
			global::android.graphics.Matrix._preScale2785 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preScale", "(FF)Z"); 
			global::android.graphics.Matrix._preRotate2786 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preRotate", "(FFF)Z"); 
			global::android.graphics.Matrix._preRotate2787 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preRotate", "(F)Z"); 
			global::android.graphics.Matrix._preSkew2788 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preSkew", "(FF)Z"); 
			global::android.graphics.Matrix._preSkew2789 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preSkew", "(FFFF)Z"); 
			global::android.graphics.Matrix._preConcat2790 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "preConcat", "(Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Matrix._postTranslate2791 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postTranslate", "(FF)Z"); 
			global::android.graphics.Matrix._postScale2792 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postScale", "(FFFF)Z"); 
			global::android.graphics.Matrix._postScale2793 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postScale", "(FF)Z"); 
			global::android.graphics.Matrix._postRotate2794 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postRotate", "(FFF)Z"); 
			global::android.graphics.Matrix._postRotate2795 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postRotate", "(F)Z"); 
			global::android.graphics.Matrix._postSkew2796 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postSkew", "(FFFF)Z"); 
			global::android.graphics.Matrix._postSkew2797 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postSkew", "(FF)Z"); 
			global::android.graphics.Matrix._postConcat2798 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "postConcat", "(Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Matrix._setRectToRect2799 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setRectToRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;Landroid/graphics/Matrix$ScaleToFit;)Z"); 
			global::android.graphics.Matrix._setPolyToPoly2800 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setPolyToPoly", "([FI[FII)Z"); 
			global::android.graphics.Matrix._invert2801 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "invert", "(Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Matrix._mapPoints2802 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapPoints", "([FI[FII)V"); 
			global::android.graphics.Matrix._mapPoints2803 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapPoints", "([F[F)V"); 
			global::android.graphics.Matrix._mapPoints2804 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapPoints", "([F)V"); 
			global::android.graphics.Matrix._mapVectors2805 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapVectors", "([FI[FII)V"); 
			global::android.graphics.Matrix._mapVectors2806 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapVectors", "([F)V"); 
			global::android.graphics.Matrix._mapVectors2807 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapVectors", "([F[F)V"); 
			global::android.graphics.Matrix._mapRect2808 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z"); 
			global::android.graphics.Matrix._mapRect2809 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;)Z"); 
			global::android.graphics.Matrix._mapRadius2810 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "mapRadius", "(F)F"); 
			global::android.graphics.Matrix._setValues2811 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "setValues", "([F)V"); 
			global::android.graphics.Matrix._Matrix2812 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "<init>", "()V"); 
			global::android.graphics.Matrix._Matrix2813 = @__env.GetMethodID(global::android.graphics.Matrix.staticClass, "<init>", "(Landroid/graphics/Matrix;)V"); 
		} 
	} 
} 
