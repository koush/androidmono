namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Path : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Path(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Direction : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Direction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Path.Direction[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Path.Direction._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Path.Direction._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.Direction.staticClass, "values", "()[Landroid/graphics/Path/Direction;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Path.Direction>(@__env.CallStaticObjectMethod(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._m0)) as android.graphics.Path.Direction[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Path.Direction valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Path.Direction._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Path.Direction._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.Direction.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Direction;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.Direction>(@__env.CallStaticObjectMethod(android.graphics.Path.Direction.staticClass, global::android.graphics.Path.Direction._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path.Direction;
			}
			internal static global::MonoJavaBridge.FieldId _CCW2340;
			public static global::android.graphics.Path.Direction CCW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.Direction>(@__env.GetStaticObjectField(global::android.graphics.Path.Direction.staticClass, _CCW2340)) as android.graphics.Path.Direction;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CW2341;
			public static global::android.graphics.Path.Direction CW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.Direction>(@__env.GetStaticObjectField(global::android.graphics.Path.Direction.staticClass, _CW2341)) as android.graphics.Path.Direction;
				}
			}
			static Direction()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Path.Direction.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path$Direction"));
				global::android.graphics.Path.Direction._CCW2340 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.Direction.staticClass, "CCW", "Landroid/graphics/Path$Direction;");
				global::android.graphics.Path.Direction._CW2341 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.Direction.staticClass, "CW", "Landroid/graphics/Path$Direction;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class FillType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal FillType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Path.FillType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Path.FillType._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Path.FillType._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.FillType.staticClass, "values", "()[Landroid/graphics/Path/FillType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Path.FillType>(@__env.CallStaticObjectMethod(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._m0)) as android.graphics.Path.FillType[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Path.FillType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Path.FillType._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Path.FillType._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Path.FillType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$FillType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.CallStaticObjectMethod(android.graphics.Path.FillType.staticClass, global::android.graphics.Path.FillType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path.FillType;
			}
			internal static global::MonoJavaBridge.FieldId _EVEN_ODD2342;
			public static global::android.graphics.Path.FillType EVEN_ODD
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _EVEN_ODD2342)) as android.graphics.Path.FillType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVERSE_EVEN_ODD2343;
			public static global::android.graphics.Path.FillType INVERSE_EVEN_ODD
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _INVERSE_EVEN_ODD2343)) as android.graphics.Path.FillType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVERSE_WINDING2344;
			public static global::android.graphics.Path.FillType INVERSE_WINDING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _INVERSE_WINDING2344)) as android.graphics.Path.FillType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WINDING2345;
			public static global::android.graphics.Path.FillType WINDING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Path.FillType>(@__env.GetStaticObjectField(global::android.graphics.Path.FillType.staticClass, _WINDING2345)) as android.graphics.Path.FillType;
				}
			}
			static FillType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Path.FillType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path$FillType"));
				global::android.graphics.Path.FillType._EVEN_ODD2342 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "EVEN_ODD", "Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._INVERSE_EVEN_ODD2343 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "INVERSE_EVEN_ODD", "Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._INVERSE_WINDING2344 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "INVERSE_WINDING", "Landroid/graphics/Path$FillType;");
				global::android.graphics.Path.FillType._WINDING2345 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Path.FillType.staticClass, "WINDING", "Landroid/graphics/Path$FillType;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "finalize", "()V", ref global::android.graphics.Path._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void offset(float arg0, float arg1, android.graphics.Path arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "offset", "(FFLandroid/graphics/Path;)V", ref global::android.graphics.Path._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void offset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "offset", "(FF)V", ref global::android.graphics.Path._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Path.staticClass, "isEmpty", "()Z", ref global::android.graphics.Path._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void transform(android.graphics.Matrix arg0, android.graphics.Path arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V", ref global::android.graphics.Path._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void transform(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "transform", "(Landroid/graphics/Matrix;)V", ref global::android.graphics.Path._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "close", "()V", ref global::android.graphics.Path._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void set(android.graphics.Path arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "set", "(Landroid/graphics/Path;)V", ref global::android.graphics.Path._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "reset", "()V", ref global::android.graphics.Path._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void rewind()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "rewind", "()V", ref global::android.graphics.Path._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isRect(android.graphics.RectF arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Path.staticClass, "isRect", "(Landroid/graphics/RectF;)Z", ref global::android.graphics.Path._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.graphics.Path.FillType getFillType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Path.FillType>(this, global::android.graphics.Path.staticClass, "getFillType", "()Landroid/graphics/Path$FillType;", ref global::android.graphics.Path._m11) as android.graphics.Path.FillType;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setFillType(android.graphics.Path.FillType arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "setFillType", "(Landroid/graphics/Path$FillType;)V", ref global::android.graphics.Path._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isInverseFillType()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Path.staticClass, "isInverseFillType", "()Z", ref global::android.graphics.Path._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void toggleInverseFillType()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "toggleInverseFillType", "()V", ref global::android.graphics.Path._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void computeBounds(android.graphics.RectF arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "computeBounds", "(Landroid/graphics/RectF;Z)V", ref global::android.graphics.Path._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void incReserve(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "incReserve", "(I)V", ref global::android.graphics.Path._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void moveTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "moveTo", "(FF)V", ref global::android.graphics.Path._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void rMoveTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "rMoveTo", "(FF)V", ref global::android.graphics.Path._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void lineTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "lineTo", "(FF)V", ref global::android.graphics.Path._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void rLineTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "rLineTo", "(FF)V", ref global::android.graphics.Path._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void quadTo(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "quadTo", "(FFFF)V", ref global::android.graphics.Path._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void rQuadTo(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "rQuadTo", "(FFFF)V", ref global::android.graphics.Path._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void cubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "cubicTo", "(FFFFFF)V", ref global::android.graphics.Path._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void rCubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "rCubicTo", "(FFFFFF)V", ref global::android.graphics.Path._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FFZ)V", ref global::android.graphics.Path._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void arcTo(android.graphics.RectF arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "arcTo", "(Landroid/graphics/RectF;FF)V", ref global::android.graphics.Path._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void addRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Path.Direction arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addRect", "(FFFFLandroid/graphics/Path$Direction;)V", ref global::android.graphics.Path._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void addRect(android.graphics.RectF arg0, android.graphics.Path.Direction arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addRect", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V", ref global::android.graphics.Path._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void addOval(android.graphics.RectF arg0, android.graphics.Path.Direction arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addOval", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V", ref global::android.graphics.Path._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void addCircle(float arg0, float arg1, float arg2, android.graphics.Path.Direction arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addCircle", "(FFFLandroid/graphics/Path$Direction;)V", ref global::android.graphics.Path._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void addArc(android.graphics.RectF arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addArc", "(Landroid/graphics/RectF;FF)V", ref global::android.graphics.Path._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void addRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Path.Direction arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Path$Direction;)V", ref global::android.graphics.Path._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void addRoundRect(android.graphics.RectF arg0, float[] arg1, android.graphics.Path.Direction arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addRoundRect", "(Landroid/graphics/RectF;[FLandroid/graphics/Path$Direction;)V", ref global::android.graphics.Path._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void addPath(android.graphics.Path arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;)V", ref global::android.graphics.Path._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void addPath(android.graphics.Path arg0, android.graphics.Matrix arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;Landroid/graphics/Matrix;)V", ref global::android.graphics.Path._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void addPath(android.graphics.Path arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "addPath", "(Landroid/graphics/Path;FF)V", ref global::android.graphics.Path._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void setLastPoint(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Path.staticClass, "setLastPoint", "(FF)V", ref global::android.graphics.Path._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public Path() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Path._m38.native == global::System.IntPtr.Zero)
				global::android.graphics.Path._m38 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._m38);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public Path(android.graphics.Path arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Path._m39.native == global::System.IntPtr.Zero)
				global::android.graphics.Path._m39 = @__env.GetMethodIDNoThrow(global::android.graphics.Path.staticClass, "<init>", "(Landroid/graphics/Path;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Path.staticClass, global::android.graphics.Path._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Path()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Path.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Path"));
		}
	}
}
