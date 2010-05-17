namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Path : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Path() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Path), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Path.Direction), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2954; 
			public static android.graphics.Path.Direction valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.Direction>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.Direction.staticClass, _valueOf2954, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2955; 
			public static android.graphics.Path.Direction[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.Direction.staticClass, _values2955)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CCW2956; 
			public static android.graphics.Path.Direction CCW
			{ 
				get 
				{ 
					return default(android.graphics.Path.Direction); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CW2957; 
			public static android.graphics.Path.Direction CW
			{ 
				get 
				{ 
					return default(android.graphics.Path.Direction); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Path.Direction.staticClass = @__class; 
				global::android.graphics.Path.Direction._valueOf2954 = @__env.GetStaticMethodID(global::android.graphics.Path.Direction.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Direction;"); 
				global::android.graphics.Path.Direction._values2955 = @__env.GetStaticMethodID(global::android.graphics.Path.Direction.staticClass, "values", "()[Landroid/graphics/Path/Direction;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class FillType : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static FillType() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Path.FillType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2958; 
			public static android.graphics.Path.FillType valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.FillType>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.FillType.staticClass, _valueOf2958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2959; 
			public static android.graphics.Path.FillType[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.FillType.staticClass, _values2959)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _EVEN_ODD2960; 
			public static android.graphics.Path.FillType EVEN_ODD
			{ 
				get 
				{ 
					return default(android.graphics.Path.FillType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _INVERSE_EVEN_ODD2961; 
			public static android.graphics.Path.FillType INVERSE_EVEN_ODD
			{ 
				get 
				{ 
					return default(android.graphics.Path.FillType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _INVERSE_WINDING2962; 
			public static android.graphics.Path.FillType INVERSE_WINDING
			{ 
				get 
				{ 
					return default(android.graphics.Path.FillType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _WINDING2963; 
			public static android.graphics.Path.FillType WINDING
			{ 
				get 
				{ 
					return default(android.graphics.Path.FillType); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Path.FillType.staticClass = @__class; 
				global::android.graphics.Path.FillType._valueOf2958 = @__env.GetStaticMethodID(global::android.graphics.Path.FillType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$FillType;"); 
				global::android.graphics.Path.FillType._values2959 = @__env.GetStaticMethodID(global::android.graphics.Path.FillType.staticClass, "values", "()[Landroid/graphics/Path/FillType;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset2964; 
		public virtual void offset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _offset2964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _offset2964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset2965; 
		public virtual void offset(float arg0, float arg1, android.graphics.Path arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _offset2965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _offset2965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty2966; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				return @__env.CallBooleanMethod(this, _isEmpty2966); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Path.staticClass, _isEmpty2966); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set2967; 
		public virtual void set(android.graphics.Path arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _set2967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _set2967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _transform2968; 
		public virtual void transform(android.graphics.Matrix arg0, android.graphics.Path arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _transform2968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _transform2968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _transform2969; 
		public virtual void transform(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _transform2969, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _transform2969, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2970; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _close2970); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _close2970); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2971; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _reset2971); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _reset2971); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rewind2972; 
		public virtual void rewind() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _rewind2972); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _rewind2972); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRect2973; 
		public virtual bool isRect(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				return @__env.CallBooleanMethod(this, _isRect2973, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Path.staticClass, _isRect2973, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFillType2974; 
		public virtual android.graphics.Path.FillType getFillType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.FillType>(@__env, @__env.CallObjectMethodPtr(this, _getFillType2974)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.FillType>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Path.staticClass, _getFillType2974)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillType2975; 
		public virtual void setFillType(android.graphics.Path.FillType arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _setFillType2975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _setFillType2975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInverseFillType2976; 
		public virtual bool isInverseFillType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				return @__env.CallBooleanMethod(this, _isInverseFillType2976); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Path.staticClass, _isInverseFillType2976); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggleInverseFillType2977; 
		public virtual void toggleInverseFillType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _toggleInverseFillType2977); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _toggleInverseFillType2977); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeBounds2978; 
		public virtual void computeBounds(android.graphics.RectF arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _computeBounds2978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _computeBounds2978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incReserve2979; 
		public virtual void incReserve(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _incReserve2979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _incReserve2979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveTo2980; 
		public virtual void moveTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _moveTo2980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _moveTo2980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rMoveTo2981; 
		public virtual void rMoveTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _rMoveTo2981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _rMoveTo2981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lineTo2982; 
		public virtual void lineTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _lineTo2982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _lineTo2982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rLineTo2983; 
		public virtual void rLineTo(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _rLineTo2983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _rLineTo2983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quadTo2984; 
		public virtual void quadTo(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _quadTo2984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _quadTo2984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rQuadTo2985; 
		public virtual void rQuadTo(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _rQuadTo2985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _rQuadTo2985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cubicTo2986; 
		public virtual void cubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _cubicTo2986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _cubicTo2986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rCubicTo2987; 
		public virtual void rCubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _rCubicTo2987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _rCubicTo2987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _arcTo2988; 
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _arcTo2988, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _arcTo2988, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _arcTo2989; 
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _arcTo2989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _arcTo2989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRect2990; 
		public virtual void addRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Path.Direction arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addRect2990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addRect2990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRect2991; 
		public virtual void addRect(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addRect2991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addRect2991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOval2992; 
		public virtual void addOval(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addOval2992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addOval2992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addCircle2993; 
		public virtual void addCircle(float arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addCircle2993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addCircle2993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addArc2994; 
		public virtual void addArc(android.graphics.RectF arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addArc2994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addArc2994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRoundRect2995; 
		public virtual void addRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addRoundRect2995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addRoundRect2995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRoundRect2996; 
		public virtual void addRoundRect(android.graphics.RectF arg0, float[] arg1, android.graphics.Path.Direction arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addRoundRect2996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addRoundRect2996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPath2997; 
		public virtual void addPath(android.graphics.Path arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addPath2997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addPath2997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPath2998; 
		public virtual void addPath(android.graphics.Path arg0, android.graphics.Matrix arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addPath2998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addPath2998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addPath2999; 
		public virtual void addPath(android.graphics.Path arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _addPath2999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _addPath2999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLastPoint3000; 
		public virtual void setLastPoint(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Path)) 
				@__env.CallVoidMethod(this, _setLastPoint3000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Path.staticClass, _setLastPoint3000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Path3001; 
		public Path()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Path.staticClass, _Path3001, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Path3002; 
		public Path(android.graphics.Path arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Path.staticClass, _Path3002, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Path.staticClass = @__class; 
			global::android.graphics.Path._offset2964 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "offset", "(FF)V"); 
			global::android.graphics.Path._offset2965 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "offset", "(FFLandroid/graphics/Path;)V"); 
			global::android.graphics.Path._isEmpty2966 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "isEmpty", "()Z"); 
			global::android.graphics.Path._set2967 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "set", "(Landroid/graphics/Path;)V"); 
			global::android.graphics.Path._transform2968 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V"); 
			global::android.graphics.Path._transform2969 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Path._close2970 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "close", "()V"); 
			global::android.graphics.Path._reset2971 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "reset", "()V"); 
			global::android.graphics.Path._rewind2972 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rewind", "()V"); 
			global::android.graphics.Path._isRect2973 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "isRect", "(Landroid/graphics/RectF;)Z"); 
			global::android.graphics.Path._getFillType2974 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "getFillType", "()Landroid/graphics/Path$FillType;"); 
			global::android.graphics.Path._setFillType2975 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "setFillType", "(Landroid/graphics/Path$FillType;)V"); 
			global::android.graphics.Path._isInverseFillType2976 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "isInverseFillType", "()Z"); 
			global::android.graphics.Path._toggleInverseFillType2977 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "toggleInverseFillType", "()V"); 
			global::android.graphics.Path._computeBounds2978 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "computeBounds", "(Landroid/graphics/RectF;Z)V"); 
			global::android.graphics.Path._incReserve2979 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "incReserve", "(I)V"); 
			global::android.graphics.Path._moveTo2980 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "moveTo", "(FF)V"); 
			global::android.graphics.Path._rMoveTo2981 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rMoveTo", "(FF)V"); 
			global::android.graphics.Path._lineTo2982 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "lineTo", "(FF)V"); 
			global::android.graphics.Path._rLineTo2983 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rLineTo", "(FF)V"); 
			global::android.graphics.Path._quadTo2984 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "quadTo", "(FFFF)V"); 
			global::android.graphics.Path._rQuadTo2985 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rQuadTo", "(FFFF)V"); 
			global::android.graphics.Path._cubicTo2986 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "cubicTo", "(FFFFFF)V"); 
			global::android.graphics.Path._rCubicTo2987 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rCubicTo", "(FFFFFF)V"); 
			global::android.graphics.Path._arcTo2988 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FFZ)V"); 
			global::android.graphics.Path._arcTo2989 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FF)V"); 
			global::android.graphics.Path._addRect2990 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRect", "(FFFFLandroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addRect2991 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRect", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addOval2992 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addOval", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addCircle2993 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addCircle", "(FFFLandroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addArc2994 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addArc", "(Landroid/graphics/RectF;FF)V"); 
			global::android.graphics.Path._addRoundRect2995 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addRoundRect2996 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;[FLandroid/graphics/Path$Direction;)V"); 
			global::android.graphics.Path._addPath2997 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;)V"); 
			global::android.graphics.Path._addPath2998 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Path._addPath2999 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;FF)V"); 
			global::android.graphics.Path._setLastPoint3000 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "setLastPoint", "(FF)V"); 
			global::android.graphics.Path._Path3001 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "<init>", "()V"); 
			global::android.graphics.Path._Path3002 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "<init>", "(Landroid/graphics/Path;)V"); 
		} 
	} 
} 
