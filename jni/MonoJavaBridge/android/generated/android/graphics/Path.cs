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
			internal static global::net.sf.jni4net.jni.MethodId _values3353;
			public static global::android.graphics.Path.Direction[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._values3353));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3354;
			public static global::android.graphics.Path.Direction valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.Direction>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._valueOf3354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CCW3355;
			public static global::android.graphics.Path.Direction CCW
			{
				get
				{
					return default(global::android.graphics.Path.Direction);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CW3356;
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
				global::android.graphics.Path.Direction._values3353 = @__env.GetStaticMethodID(global::android.graphics.Path.Direction.staticClass, "values", "()[Landroid/graphics/Path/Direction;");
				global::android.graphics.Path.Direction._valueOf3354 = @__env.GetStaticMethodID(global::android.graphics.Path.Direction.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Direction;");
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
			internal static global::net.sf.jni4net.jni.MethodId _values3357;
			public static global::android.graphics.Path.FillType[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._values3357));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3358;
			public static global::android.graphics.Path.FillType valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.FillType>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._valueOf3358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _EVEN_ODD3359;
			public static global::android.graphics.Path.FillType EVEN_ODD
			{
				get
				{
					return default(global::android.graphics.Path.FillType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INVERSE_EVEN_ODD3360;
			public static global::android.graphics.Path.FillType INVERSE_EVEN_ODD
			{
				get
				{
					return default(global::android.graphics.Path.FillType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INVERSE_WINDING3361;
			public static global::android.graphics.Path.FillType INVERSE_WINDING
			{
				get
				{
					return default(global::android.graphics.Path.FillType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _WINDING3362;
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
				global::android.graphics.Path.FillType._values3357 = @__env.GetStaticMethodID(global::android.graphics.Path.FillType.staticClass, "values", "()[Landroid/graphics/Path/FillType;");
				global::android.graphics.Path.FillType._valueOf3358 = @__env.GetStaticMethodID(global::android.graphics.Path.FillType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$FillType;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _offset3363;
		public virtual void offset(float arg0, float arg1, android.graphics.Path arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._offset3363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset3363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _offset3364;
		public virtual void offset(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._offset3364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._offset3364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3365;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Path._isEmpty3365);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._isEmpty3365);
		}
		internal static global::net.sf.jni4net.jni.MethodId _transform3366;
		public virtual void transform(android.graphics.Matrix arg0, android.graphics.Path arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._transform3366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform3366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _transform3367;
		public virtual void transform(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._transform3367, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._transform3367, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close3368;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._close3368);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._close3368);
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3369;
		public virtual void set(android.graphics.Path arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._set3369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._set3369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset3370;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._reset3370);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._reset3370);
		}
		internal static global::net.sf.jni4net.jni.MethodId _rewind3371;
		public virtual void rewind() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._rewind3371);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rewind3371);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRect3372;
		public virtual bool isRect(android.graphics.RectF arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Path._isRect3372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._isRect3372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFillType3373;
		public virtual global::android.graphics.Path.FillType getFillType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.FillType>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Path._getFillType3373));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path.FillType>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._getFillType3373));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFillType3374;
		public virtual void setFillType(android.graphics.Path.FillType arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._setFillType3374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._setFillType3374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInverseFillType3375;
		public virtual bool isInverseFillType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Path._isInverseFillType3375);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._isInverseFillType3375);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toggleInverseFillType3376;
		public virtual void toggleInverseFillType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._toggleInverseFillType3376);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._toggleInverseFillType3376);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeBounds3377;
		public virtual void computeBounds(android.graphics.RectF arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._computeBounds3377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._computeBounds3377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _incReserve3378;
		public virtual void incReserve(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._incReserve3378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._incReserve3378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveTo3379;
		public virtual void moveTo(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._moveTo3379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._moveTo3379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rMoveTo3380;
		public virtual void rMoveTo(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._rMoveTo3380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rMoveTo3380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _lineTo3381;
		public virtual void lineTo(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._lineTo3381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._lineTo3381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rLineTo3382;
		public virtual void rLineTo(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._rLineTo3382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rLineTo3382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quadTo3383;
		public virtual void quadTo(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._quadTo3383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._quadTo3383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rQuadTo3384;
		public virtual void rQuadTo(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._rQuadTo3384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rQuadTo3384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cubicTo3385;
		public virtual void cubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._cubicTo3385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._cubicTo3385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rCubicTo3386;
		public virtual void rCubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._rCubicTo3386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._rCubicTo3386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _arcTo3387;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._arcTo3387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo3387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _arcTo3388;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._arcTo3388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._arcTo3388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addRect3389;
		public virtual void addRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Path.Direction arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addRect3389, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect3389, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addRect3390;
		public virtual void addRect(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addRect3390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRect3390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOval3391;
		public virtual void addOval(android.graphics.RectF arg0, android.graphics.Path.Direction arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addOval3391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addOval3391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addCircle3392;
		public virtual void addCircle(float arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addCircle3392, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addCircle3392, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addArc3393;
		public virtual void addArc(android.graphics.RectF arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addArc3393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addArc3393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addRoundRect3394;
		public virtual void addRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Path.Direction arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addRoundRect3394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect3394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addRoundRect3395;
		public virtual void addRoundRect(android.graphics.RectF arg0, float[] arg1, android.graphics.Path.Direction arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addRoundRect3395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addRoundRect3395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addPath3396;
		public virtual void addPath(android.graphics.Path arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addPath3396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath3396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addPath3397;
		public virtual void addPath(android.graphics.Path arg0, android.graphics.Matrix arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addPath3397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath3397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addPath3398;
		public virtual void addPath(android.graphics.Path arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._addPath3398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._addPath3398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLastPoint3399;
		public virtual void setLastPoint(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Path._setLastPoint3399, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Path.staticClass, global::android.graphics.Path._setLastPoint3399, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Path3400;
		public Path()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path3400, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Path3401;
		public Path(android.graphics.Path arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._Path3401, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Path.staticClass = @__class;
			global::android.graphics.Path._offset3363 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "offset", "(FFLandroid/graphics/Path;)V");
			global::android.graphics.Path._offset3364 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "offset", "(FF)V");
			global::android.graphics.Path._isEmpty3365 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "isEmpty", "()Z");
			global::android.graphics.Path._transform3366 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V");
			global::android.graphics.Path._transform3367 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Path._close3368 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "close", "()V");
			global::android.graphics.Path._set3369 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "set", "(Landroid/graphics/Path;)V");
			global::android.graphics.Path._reset3370 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "reset", "()V");
			global::android.graphics.Path._rewind3371 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rewind", "()V");
			global::android.graphics.Path._isRect3372 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "isRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Path._getFillType3373 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "getFillType", "()Landroid/graphics/Path$FillType;");
			global::android.graphics.Path._setFillType3374 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "setFillType", "(Landroid/graphics/Path$FillType;)V");
			global::android.graphics.Path._isInverseFillType3375 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "isInverseFillType", "()Z");
			global::android.graphics.Path._toggleInverseFillType3376 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "toggleInverseFillType", "()V");
			global::android.graphics.Path._computeBounds3377 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "computeBounds", "(Landroid/graphics/RectF;Z)V");
			global::android.graphics.Path._incReserve3378 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "incReserve", "(I)V");
			global::android.graphics.Path._moveTo3379 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "moveTo", "(FF)V");
			global::android.graphics.Path._rMoveTo3380 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rMoveTo", "(FF)V");
			global::android.graphics.Path._lineTo3381 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "lineTo", "(FF)V");
			global::android.graphics.Path._rLineTo3382 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rLineTo", "(FF)V");
			global::android.graphics.Path._quadTo3383 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "quadTo", "(FFFF)V");
			global::android.graphics.Path._rQuadTo3384 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rQuadTo", "(FFFF)V");
			global::android.graphics.Path._cubicTo3385 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "cubicTo", "(FFFFFF)V");
			global::android.graphics.Path._rCubicTo3386 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "rCubicTo", "(FFFFFF)V");
			global::android.graphics.Path._arcTo3387 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FFZ)V");
			global::android.graphics.Path._arcTo3388 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FF)V");
			global::android.graphics.Path._addRect3389 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRect", "(FFFFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addRect3390 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRect", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addOval3391 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addOval", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addCircle3392 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addCircle", "(FFFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addArc3393 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addArc", "(Landroid/graphics/RectF;FF)V");
			global::android.graphics.Path._addRoundRect3394 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addRoundRect3395 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;[FLandroid/graphics/Path$Direction;)V");
			global::android.graphics.Path._addPath3396 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;)V");
			global::android.graphics.Path._addPath3397 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;Landroid/graphics/Matrix;)V");
			global::android.graphics.Path._addPath3398 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;FF)V");
			global::android.graphics.Path._setLastPoint3399 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "setLastPoint", "(FF)V");
			global::android.graphics.Path._Path3400 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "<init>", "()V");
			global::android.graphics.Path._Path3401 = @__env.GetMethodID(global::android.graphics.Path.staticClass, "<init>", "(Landroid/graphics/Path;)V");
		}
	}
}
