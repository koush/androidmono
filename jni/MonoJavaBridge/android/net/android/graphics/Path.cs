namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Path : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Path() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Path), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.Path(@__env); 
			} 
		} 
		protected Path(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Direction : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Direction() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Path.Direction), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Path.Direction(@__env); 
				} 
			} 
			internal Direction(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3154; 
			public static global::android.graphics.Path.Direction valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.Direction>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._valueOf3154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3155; 
			public static global::android.graphics.Path.Direction[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._values3155)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CCW3156; 
			public static global::android.graphics.Path.Direction CCW
			{ 
				get 
				{ 
					return default(global::android.graphics.Path.Direction); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CW3157; 
			public static global::android.graphics.Path.Direction CW
			{ 
				get 
				{ 
					return default(global::android.graphics.Path.Direction); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Path.Direction.staticClass = @__class; 
				global::android.graphics.Path.Direction._valueOf3154 = @__env.GetStaticMethodID(global::android.graphics.Path.Direction.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Direction;"); 
				global::android.graphics.Path.Direction._values3155 = @__env.GetStaticMethodID(global::android.graphics.Path.Direction.staticClass, "values", "()[Landroid/graphics/Path/Direction;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class FillType : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static FillType() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Path.FillType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Path.FillType(@__env); 
				} 
			} 
			internal FillType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3158; 
			public static global::android.graphics.Path.FillType valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.FillType>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._valueOf3158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3159; 
			public static global::android.graphics.Path.FillType[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._values3159)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _EVEN_ODD3160; 
			public static global::android.graphics.Path.FillType EVEN_ODD
			{ 
				get 
				{ 
					return default(global::android.graphics.Path.FillType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _INVERSE_EVEN_ODD3161; 
			public static global::android.graphics.Path.FillType INVERSE_EVEN_ODD
			{ 
				get 
				{ 
					return default(global::android.graphics.Path.FillType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _INVERSE_WINDING3162; 
			public static global::android.graphics.Path.FillType INVERSE_WINDING
			{ 
				get 
				{ 
					return default(global::android.graphics.Path.FillType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _WINDING3163; 
			public static global::android.graphics.Path.FillType WINDING
			{ 
				get 
				{ 
					return default(global::android.graphics.Path.FillType); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Path.FillType.staticClass = @__class; 
				global::android.graphics.Path.FillType._valueOf3158 = @__env.GetStaticMethodID(global::android.graphics.Path.FillType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$FillType;"); 
				global::android.graphics.Path.FillType._values3159 = @__env.GetStaticMethodID(global::android.graphics.Path.FillType.staticClass, "values", "()[Landroid/graphics/Path/FillType;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset3164; 
		public virtual void offset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._offset3164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset3164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset3165; 
		public virtual void offset(float arg0, float arg1, android.graphics.Path arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._offset3165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset3165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3166; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Path._isEmpty3166); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._isEmpty3166); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3167; 
		public virtual void set(android.graphics.Path arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._set3167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._set3167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _transform3168; 
		public virtual void transform(android.graphics.Matrix arg0, android.graphics.Path arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._transform3168, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform3168, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _transform3169; 
		public virtual void transform(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._transform3169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform3169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close3170; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._close3170); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._close3170); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset3171; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._reset3171); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._reset3171); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rewind3172; 
		public virtual void rewind() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._rewind3172); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rewind3172); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRect3173; 
		public virtual bool isRect(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Path._isRect3173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._isRect3173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFillType3174; 
		public virtual global::android.graphics.Path.FillType getFillType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.FillType>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Path._getFillType3174)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.FillType>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._getFillType3174)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillType3175; 
		public virtual void setFillType(android.graphics.Path.FillType arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._setFillType3175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._setFillType3175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInverseFillType3176; 
		public virtual bool isInverseFillType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Path._isInverseFillType3176); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._isInverseFillType3176); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggleInverseFillType3177; 
		public virtual void toggleInverseFillType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._toggleInverseFillType3177); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._toggleInverseFillType3177); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeBounds3178; 
		public virtual void computeBounds(android.graphics.RectF arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._computeBounds3178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._computeBounds3178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incReserve3179; 
		public virtual void incReserve(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._incReserve3179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._incReserve3179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveTo3180; 
		public virtual void moveTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._moveTo3180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._moveTo3180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rMoveTo3181; 
		public virtual void rMoveTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._rMoveTo3181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rMoveTo3181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lineTo3182; 
		public virtual void lineTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._lineTo3182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._lineTo3182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rLineTo3183; 
		public virtual void rLineTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._rLineTo3183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rLineTo3183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quadTo3184; 
		public virtual void quadTo(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._quadTo3184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._quadTo3184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rQuadTo3185; 
		public virtual void rQuadTo(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._rQuadTo3185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rQuadTo3185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cubicTo3186; 
		public virtual void cubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._cubicTo3186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._cubicTo3186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rCubicTo3187; 
		public virtual void rCubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._rCubicTo3187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rCubicTo3187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _arcTo3188; 
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._arcTo3188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo3188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _arcTo3189; 
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._arcTo3189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo3189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRect3190; 
		public virtual void addRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Path.Direction arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addRect3190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect3190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRect3191; 
		public virtual void addRect(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addRect3191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect3191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOval3192; 
		public virtual void addOval(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addOval3192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addOval3192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addCircle3193; 
		public virtual void addCircle(float arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addCircle3193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addCircle3193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addArc3194; 
		public virtual void addArc(android.graphics.RectF arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addArc3194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addArc3194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRoundRect3195; 
		public virtual void addRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addRoundRect3195, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect3195, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRoundRect3196; 
		public virtual void addRoundRect(android.graphics.RectF arg0, float[] arg1, android.graphics.Path.Direction arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addRoundRect3196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect3196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPath3197; 
		public virtual void addPath(android.graphics.Path arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addPath3197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath3197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPath3198; 
		public virtual void addPath(android.graphics.Path arg0, android.graphics.Matrix arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addPath3198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath3198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPath3199; 
		public virtual void addPath(android.graphics.Path arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._addPath3199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath3199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLastPoint3200; 
		public virtual void setLastPoint(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Path._setLastPoint3200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._setLastPoint3200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Path3201; 
		public Path()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path3201, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Path3202; 
		public Path(android.graphics.Path arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path3202, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Path.staticClass = @__class; 
			global::android.graphics.Path._offset3164 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "offset", "(FF)V"); 
			global::android.graphics.Path._offset3165 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "offset", "(FFLandroid/graphics/Path;)V"); 
			global::android.graphics.Path._isEmpty3166 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "isEmpty", "()Z"); 
			global::android.graphics.Path._set3167 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "set", "(Landroid/graphics/Path;)V"); 
			global::android.graphics.Path._transform3168 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V"); 
			global::android.graphics.Path._transform3169 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Path._close3170 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "close", "()V"); 
			global::android.graphics.Path._reset3171 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "reset", "()V"); 
			global::android.graphics.Path._rewind3172 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rewind", "()V"); 
			global::android.graphics.Path._isRect3173 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "isRect", "(Landroid/graphics/RectF;)Z"); 
			global::android.graphics.Path._getFillType3174 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "getFillType", "()Landroid/graphics/Path$FillType;"); 
			global::android.graphics.Path._setFillType3175 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "setFillType", "(Landroid/graphics/Path$FillType;)V"); 
			global::android.graphics.Path._isInverseFillType3176 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "isInverseFillType", "()Z"); 
			global::android.graphics.Path._toggleInverseFillType3177 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "toggleInverseFillType", "()V"); 
			global::android.graphics.Path._computeBounds3178 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "computeBounds", "(Landroid/graphics/RectF;Z)V"); 
			global::android.graphics.Path._incReserve3179 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "incReserve", "(I)V"); 
			global::android.graphics.Path._moveTo3180 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "moveTo", "(FF)V"); 
			global::android.graphics.Path._rMoveTo3181 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rMoveTo", "(FF)V"); 
			global::android.graphics.Path._lineTo3182 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "lineTo", "(FF)V"); 
			global::android.graphics.Path._rLineTo3183 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rLineTo", "(FF)V"); 
			global::android.graphics.Path._quadTo3184 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "quadTo", "(FFFF)V"); 
			global::android.graphics.Path._rQuadTo3185 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rQuadTo", "(FFFF)V"); 
			global::android.graphics.Path._cubicTo3186 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "cubicTo", "(FFFFFF)V"); 
			global::android.graphics.Path._rCubicTo3187 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rCubicTo", "(FFFFFF)V"); 
			global::android.graphics.Path._arcTo3188 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FFZ)V"); 
			global::android.graphics.Path._arcTo3189 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FF)V"); 
			global::android.graphics.Path._addRect3190 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRect", "(FFFFLandroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addRect3191 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRect", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addOval3192 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addOval", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addCircle3193 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addCircle", "(FFFLandroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addArc3194 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addArc", "(Landroid/graphics/RectF;FF)V"); 
			global::android.graphics.Path._addRoundRect3195 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addRoundRect3196 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;[FLandroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addPath3197 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;)V"); 
			global::android.graphics.Path._addPath3198 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Path._addPath3199 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;FF)V"); 
			global::android.graphics.Path._setLastPoint3200 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "setLastPoint", "(FF)V"); 
			global::android.graphics.Path._Path3201 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "<init>", "()V"); 
			global::android.graphics.Path._Path3202 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "<init>", "(Landroid/graphics/Path;)V"); 
		} 
	} 
} 
