namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Matrix : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Matrix(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ScaleToFit : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ScaleToFit(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Matrix.ScaleToFit[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Matrix.ScaleToFit._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Matrix.ScaleToFit._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "values", "()[Landroid/graphics/Matrix/ScaleToFit;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Matrix.ScaleToFit>(@__env.CallStaticObjectMethod(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._m0)) as android.graphics.Matrix.ScaleToFit[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Matrix.ScaleToFit valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Matrix.ScaleToFit._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Matrix.ScaleToFit._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Matrix$ScaleToFit;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Matrix.ScaleToFit>(@__env.CallStaticObjectMethod(android.graphics.Matrix.ScaleToFit.staticClass, global::android.graphics.Matrix.ScaleToFit._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Matrix.ScaleToFit;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER2296;
			public static global::android.graphics.Matrix.ScaleToFit CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Matrix.ScaleToFit>(@__env.GetStaticObjectField(global::android.graphics.Matrix.ScaleToFit.staticClass, _CENTER2296)) as android.graphics.Matrix.ScaleToFit;
				}
			}
			internal static global::MonoJavaBridge.FieldId _END2297;
			public static global::android.graphics.Matrix.ScaleToFit END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Matrix.ScaleToFit>(@__env.GetStaticObjectField(global::android.graphics.Matrix.ScaleToFit.staticClass, _END2297)) as android.graphics.Matrix.ScaleToFit;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FILL2298;
			public static global::android.graphics.Matrix.ScaleToFit FILL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Matrix.ScaleToFit>(@__env.GetStaticObjectField(global::android.graphics.Matrix.ScaleToFit.staticClass, _FILL2298)) as android.graphics.Matrix.ScaleToFit;
				}
			}
			internal static global::MonoJavaBridge.FieldId _START2299;
			public static global::android.graphics.Matrix.ScaleToFit START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Matrix.ScaleToFit>(@__env.GetStaticObjectField(global::android.graphics.Matrix.ScaleToFit.staticClass, _START2299)) as android.graphics.Matrix.ScaleToFit;
				}
			}
			static ScaleToFit()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Matrix.ScaleToFit.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Matrix$ScaleToFit"));
				global::android.graphics.Matrix.ScaleToFit._CENTER2296 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "CENTER", "Landroid/graphics/Matrix$ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._END2297 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "END", "Landroid/graphics/Matrix$ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._FILL2298 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "FILL", "Landroid/graphics/Matrix$ScaleToFit;");
				global::android.graphics.Matrix.ScaleToFit._START2299 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Matrix.ScaleToFit.staticClass, "START", "Landroid/graphics/Matrix$ScaleToFit;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "finalize", "()V", ref global::android.graphics.Matrix._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.graphics.Matrix._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Matrix.staticClass, "toString", "()Ljava/lang/String;", ref global::android.graphics.Matrix._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void set(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "set", "(Landroid/graphics/Matrix;)V", ref global::android.graphics.Matrix._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "reset", "()V", ref global::android.graphics.Matrix._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String toShortString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Matrix.staticClass, "toShortString", "()Ljava/lang/String;", ref global::android.graphics.Matrix._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void getValues(float[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "getValues", "([F)V", ref global::android.graphics.Matrix._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isIdentity()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "isIdentity", "()Z", ref global::android.graphics.Matrix._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool rectStaysRect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "rectStaysRect", "()Z", ref global::android.graphics.Matrix._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setTranslate(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setTranslate", "(FF)V", ref global::android.graphics.Matrix._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setScale(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setScale", "(FF)V", ref global::android.graphics.Matrix._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setScale", "(FFFF)V", ref global::android.graphics.Matrix._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setRotate(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setRotate", "(FFF)V", ref global::android.graphics.Matrix._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new float Rotate
		{
			set
			{
				setRotate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setRotate(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setRotate", "(F)V", ref global::android.graphics.Matrix._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setSinCos(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setSinCos", "(FFFF)V", ref global::android.graphics.Matrix._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setSinCos(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setSinCos", "(FF)V", ref global::android.graphics.Matrix._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setSkew(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setSkew", "(FFFF)V", ref global::android.graphics.Matrix._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setSkew(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setSkew", "(FF)V", ref global::android.graphics.Matrix._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool setConcat(android.graphics.Matrix arg0, android.graphics.Matrix arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "setConcat", "(Landroid/graphics/Matrix;Landroid/graphics/Matrix;)Z", ref global::android.graphics.Matrix._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool preTranslate(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "preTranslate", "(FF)Z", ref global::android.graphics.Matrix._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool preScale(float arg0, float arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "preScale", "(FFFF)Z", ref global::android.graphics.Matrix._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool preScale(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "preScale", "(FF)Z", ref global::android.graphics.Matrix._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool preRotate(float arg0, float arg1, float arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "preRotate", "(FFF)Z", ref global::android.graphics.Matrix._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool preRotate(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "preRotate", "(F)Z", ref global::android.graphics.Matrix._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool preSkew(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "preSkew", "(FF)Z", ref global::android.graphics.Matrix._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool preSkew(float arg0, float arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "preSkew", "(FFFF)Z", ref global::android.graphics.Matrix._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool preConcat(android.graphics.Matrix arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "preConcat", "(Landroid/graphics/Matrix;)Z", ref global::android.graphics.Matrix._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool postTranslate(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "postTranslate", "(FF)Z", ref global::android.graphics.Matrix._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool postScale(float arg0, float arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "postScale", "(FFFF)Z", ref global::android.graphics.Matrix._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool postScale(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "postScale", "(FF)Z", ref global::android.graphics.Matrix._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool postRotate(float arg0, float arg1, float arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "postRotate", "(FFF)Z", ref global::android.graphics.Matrix._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool postRotate(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "postRotate", "(F)Z", ref global::android.graphics.Matrix._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual bool postSkew(float arg0, float arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "postSkew", "(FFFF)Z", ref global::android.graphics.Matrix._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool postSkew(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "postSkew", "(FF)Z", ref global::android.graphics.Matrix._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool postConcat(android.graphics.Matrix arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "postConcat", "(Landroid/graphics/Matrix;)Z", ref global::android.graphics.Matrix._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual bool setRectToRect(android.graphics.RectF arg0, android.graphics.RectF arg1, android.graphics.Matrix.ScaleToFit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "setRectToRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;Landroid/graphics/Matrix$ScaleToFit;)Z", ref global::android.graphics.Matrix._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual bool setPolyToPoly(float[] arg0, int arg1, float[] arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "setPolyToPoly", "([FI[FII)Z", ref global::android.graphics.Matrix._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool invert(android.graphics.Matrix arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "invert", "(Landroid/graphics/Matrix;)Z", ref global::android.graphics.Matrix._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void mapPoints(float[] arg0, int arg1, float[] arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "mapPoints", "([FI[FII)V", ref global::android.graphics.Matrix._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void mapPoints(float[] arg0, float[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "mapPoints", "([F[F)V", ref global::android.graphics.Matrix._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void mapPoints(float[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "mapPoints", "([F)V", ref global::android.graphics.Matrix._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void mapVectors(float[] arg0, int arg1, float[] arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "mapVectors", "([FI[FII)V", ref global::android.graphics.Matrix._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual void mapVectors(float[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "mapVectors", "([F)V", ref global::android.graphics.Matrix._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void mapVectors(float[] arg0, float[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "mapVectors", "([F[F)V", ref global::android.graphics.Matrix._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual bool mapRect(android.graphics.RectF arg0, android.graphics.RectF arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z", ref global::android.graphics.Matrix._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual bool mapRect(android.graphics.RectF arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Matrix.staticClass, "mapRect", "(Landroid/graphics/RectF;)Z", ref global::android.graphics.Matrix._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual float mapRadius(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Matrix.staticClass, "mapRadius", "(F)F", ref global::android.graphics.Matrix._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float[] Values
		{
			set
			{
				setValues(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual void setValues(float[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Matrix.staticClass, "setValues", "([F)V", ref global::android.graphics.Matrix._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public Matrix() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Matrix._m48.native == global::System.IntPtr.Zero)
				global::android.graphics.Matrix._m48 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._m48);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public Matrix(android.graphics.Matrix arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Matrix._m49.native == global::System.IntPtr.Zero)
				global::android.graphics.Matrix._m49 = @__env.GetMethodIDNoThrow(global::android.graphics.Matrix.staticClass, "<init>", "(Landroid/graphics/Matrix;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Matrix.staticClass, global::android.graphics.Matrix._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		static Matrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Matrix.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Matrix"));
		}
	}
}
