namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Canvas : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Canvas(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class EdgeType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal EdgeType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Canvas.EdgeType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Canvas.EdgeType._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Canvas.EdgeType._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "values", "()[Landroid/graphics/Canvas/EdgeType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Canvas.EdgeType>(@__env.CallStaticObjectMethod(android.graphics.Canvas.EdgeType.staticClass, global::android.graphics.Canvas.EdgeType._m0)) as android.graphics.Canvas.EdgeType[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Canvas.EdgeType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Canvas.EdgeType._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Canvas.EdgeType._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$EdgeType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.EdgeType>(@__env.CallStaticObjectMethod(android.graphics.Canvas.EdgeType.staticClass, global::android.graphics.Canvas.EdgeType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas.EdgeType;
			}
			internal static global::MonoJavaBridge.FieldId _AA2264;
			public static global::android.graphics.Canvas.EdgeType AA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.EdgeType>(@__env.GetStaticObjectField(global::android.graphics.Canvas.EdgeType.staticClass, _AA2264)) as android.graphics.Canvas.EdgeType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BW2265;
			public static global::android.graphics.Canvas.EdgeType BW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.EdgeType>(@__env.GetStaticObjectField(global::android.graphics.Canvas.EdgeType.staticClass, _BW2265)) as android.graphics.Canvas.EdgeType;
				}
			}
			static EdgeType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Canvas.EdgeType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Canvas$EdgeType"));
				global::android.graphics.Canvas.EdgeType._AA2264 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "AA", "Landroid/graphics/Canvas$EdgeType;");
				global::android.graphics.Canvas.EdgeType._BW2265 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "BW", "Landroid/graphics/Canvas$EdgeType;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class VertexMode : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal VertexMode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Canvas.VertexMode[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Canvas.VertexMode._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Canvas.VertexMode._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "values", "()[Landroid/graphics/Canvas/VertexMode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Canvas.VertexMode>(@__env.CallStaticObjectMethod(android.graphics.Canvas.VertexMode.staticClass, global::android.graphics.Canvas.VertexMode._m0)) as android.graphics.Canvas.VertexMode[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Canvas.VertexMode valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Canvas.VertexMode._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Canvas.VertexMode._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$VertexMode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.VertexMode>(@__env.CallStaticObjectMethod(android.graphics.Canvas.VertexMode.staticClass, global::android.graphics.Canvas.VertexMode._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas.VertexMode;
			}
			internal static global::MonoJavaBridge.FieldId _TRIANGLES2266;
			public static global::android.graphics.Canvas.VertexMode TRIANGLES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.VertexMode>(@__env.GetStaticObjectField(global::android.graphics.Canvas.VertexMode.staticClass, _TRIANGLES2266)) as android.graphics.Canvas.VertexMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TRIANGLE_FAN2267;
			public static global::android.graphics.Canvas.VertexMode TRIANGLE_FAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.VertexMode>(@__env.GetStaticObjectField(global::android.graphics.Canvas.VertexMode.staticClass, _TRIANGLE_FAN2267)) as android.graphics.Canvas.VertexMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TRIANGLE_STRIP2268;
			public static global::android.graphics.Canvas.VertexMode TRIANGLE_STRIP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.VertexMode>(@__env.GetStaticObjectField(global::android.graphics.Canvas.VertexMode.staticClass, _TRIANGLE_STRIP2268)) as android.graphics.Canvas.VertexMode;
				}
			}
			static VertexMode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Canvas.VertexMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Canvas$VertexMode"));
				global::android.graphics.Canvas.VertexMode._TRIANGLES2266 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "TRIANGLES", "Landroid/graphics/Canvas$VertexMode;");
				global::android.graphics.Canvas.VertexMode._TRIANGLE_FAN2267 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "TRIANGLE_FAN", "Landroid/graphics/Canvas$VertexMode;");
				global::android.graphics.Canvas.VertexMode._TRIANGLE_STRIP2268 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "TRIANGLE_STRIP", "Landroid/graphics/Canvas$VertexMode;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "finalize", "()V", ref global::android.graphics.Canvas._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void concat(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "concat", "(Landroid/graphics/Matrix;)V", ref global::android.graphics.Canvas._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int save()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "save", "()I", ref global::android.graphics.Canvas._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int save(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "save", "(I)I", ref global::android.graphics.Canvas._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void rotate(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "rotate", "(FFF)V", ref global::android.graphics.Canvas._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void rotate(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "rotate", "(F)V", ref global::android.graphics.Canvas._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isOpaque()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "isOpaque", "()Z", ref global::android.graphics.Canvas._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void scale(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "scale", "(FFFF)V", ref global::android.graphics.Canvas._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void scale(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "scale", "(FF)V", ref global::android.graphics.Canvas._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Density
		{
			get
			{
				return getDensity();
			}
			set
			{
				setDensity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getDensity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "getDensity", "()I", ref global::android.graphics.Canvas._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setDensity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "setDensity", "(I)V", ref global::android.graphics.Canvas._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "getWidth", "()I", ref global::android.graphics.Canvas._m11);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "getHeight", "()I", ref global::android.graphics.Canvas._m12);
		}
		public new global::javax.microedition.khronos.opengles.GL GL
		{
			get
			{
				return getGL();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::javax.microedition.khronos.opengles.GL getGL()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.microedition.khronos.opengles.GL>(this, global::android.graphics.Canvas.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;", ref global::android.graphics.Canvas._m13) as javax.microedition.khronos.opengles.GL;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void freeGlCaches()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Canvas._m14.native == global::System.IntPtr.Zero)
				global::android.graphics.Canvas._m14 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "freeGlCaches", "()V");
			@__env.CallStaticVoidMethod(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._m14);
		}
		public new global::android.graphics.Bitmap Bitmap
		{
			set
			{
				setBitmap(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setBitmap(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V", ref global::android.graphics.Canvas._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setViewport(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "setViewport", "(II)V", ref global::android.graphics.Canvas._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int saveLayer(android.graphics.RectF arg0, android.graphics.Paint arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "saveLayer", "(Landroid/graphics/RectF;Landroid/graphics/Paint;I)I", ref global::android.graphics.Canvas._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int saveLayer(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "saveLayer", "(FFFFLandroid/graphics/Paint;I)I", ref global::android.graphics.Canvas._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int saveLayerAlpha(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(FFFFII)I", ref global::android.graphics.Canvas._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int saveLayerAlpha(android.graphics.RectF arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(Landroid/graphics/RectF;II)I", ref global::android.graphics.Canvas._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void restore()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "restore", "()V", ref global::android.graphics.Canvas._m21);
		}
		public new int SaveCount
		{
			get
			{
				return getSaveCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getSaveCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Canvas.staticClass, "getSaveCount", "()I", ref global::android.graphics.Canvas._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void restoreToCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "restoreToCount", "(I)V", ref global::android.graphics.Canvas._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void translate(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "translate", "(FF)V", ref global::android.graphics.Canvas._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void skew(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "skew", "(FF)V", ref global::android.graphics.Canvas._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setMatrix(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "setMatrix", "(Landroid/graphics/Matrix;)V", ref global::android.graphics.Canvas._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Matrix Matrix
		{
			get
			{
				return getMatrix();
			}
			set
			{
				setMatrix(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::android.graphics.Matrix getMatrix()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Canvas.staticClass, "getMatrix", "()Landroid/graphics/Matrix;", ref global::android.graphics.Canvas._m27) as android.graphics.Matrix;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void getMatrix(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V", ref global::android.graphics.Canvas._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool clipRect(android.graphics.Rect arg0, android.graphics.Region.Op arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z", ref global::android.graphics.Canvas._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool clipRect(android.graphics.RectF arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;)Z", ref global::android.graphics.Canvas._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool clipRect(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Canvas._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Region.Op arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipRect", "(FFFFLandroid/graphics/Region$Op;)Z", ref global::android.graphics.Canvas._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipRect", "(FFFF)Z", ref global::android.graphics.Canvas._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool clipRect(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipRect", "(IIII)Z", ref global::android.graphics.Canvas._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual bool clipRect(android.graphics.RectF arg0, android.graphics.Region.Op arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;Landroid/graphics/Region$Op;)Z", ref global::android.graphics.Canvas._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual bool clipPath(android.graphics.Path arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;)Z", ref global::android.graphics.Canvas._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool clipPath(android.graphics.Path arg0, android.graphics.Region.Op arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;Landroid/graphics/Region$Op;)Z", ref global::android.graphics.Canvas._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual bool clipRegion(android.graphics.Region arg0, android.graphics.Region.Op arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z", ref global::android.graphics.Canvas._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual bool clipRegion(android.graphics.Region arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;)Z", ref global::android.graphics.Canvas._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.DrawFilter DrawFilter
		{
			get
			{
				return getDrawFilter();
			}
			set
			{
				setDrawFilter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::android.graphics.DrawFilter getDrawFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Canvas.staticClass, "getDrawFilter", "()Landroid/graphics/DrawFilter;", ref global::android.graphics.Canvas._m40) as android.graphics.DrawFilter;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void setDrawFilter(android.graphics.DrawFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "setDrawFilter", "(Landroid/graphics/DrawFilter;)V", ref global::android.graphics.Canvas._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual bool quickReject(android.graphics.RectF arg0, android.graphics.Canvas.EdgeType arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/RectF;Landroid/graphics/Canvas$EdgeType;)Z", ref global::android.graphics.Canvas._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual bool quickReject(android.graphics.Path arg0, android.graphics.Canvas.EdgeType arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/Path;Landroid/graphics/Canvas$EdgeType;)Z", ref global::android.graphics.Canvas._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual bool quickReject(float arg0, float arg1, float arg2, float arg3, android.graphics.Canvas.EdgeType arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "quickReject", "(FFFFLandroid/graphics/Canvas$EdgeType;)Z", ref global::android.graphics.Canvas._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new global::android.graphics.Rect ClipBounds
		{
			get
			{
				return getClipBounds();
			}
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual global::android.graphics.Rect getClipBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Rect>(this, global::android.graphics.Canvas.staticClass, "getClipBounds", "()Landroid/graphics/Rect;", ref global::android.graphics.Canvas._m45) as android.graphics.Rect;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual bool getClipBounds(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Canvas.staticClass, "getClipBounds", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Canvas._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual void drawRGB(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawRGB", "(III)V", ref global::android.graphics.Canvas._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual void drawARGB(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawARGB", "(IIII)V", ref global::android.graphics.Canvas._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual void drawColor(int arg0, android.graphics.PorterDuff.Mode arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawColor", "(ILandroid/graphics/PorterDuff$Mode;)V", ref global::android.graphics.Canvas._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual void drawColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawColor", "(I)V", ref global::android.graphics.Canvas._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual void drawPaint(android.graphics.Paint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPaint", "(Landroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual void drawPoints(float[] arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPoints", "([FLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual void drawPoints(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPoints", "([FIILandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual void drawPoint(float arg0, float arg1, android.graphics.Paint arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPoint", "(FFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual void drawLine(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawLine", "(FFFFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual void drawLines(float[] arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawLines", "([FLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual void drawLines(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawLines", "([FIILandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual void drawRect(android.graphics.Rect arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/Rect;Landroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual void drawRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawRect", "(FFFFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual void drawRect(android.graphics.RectF arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual void drawOval(android.graphics.RectF arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawOval", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual void drawCircle(float arg0, float arg1, float arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawCircle", "(FFFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual void drawArc(android.graphics.RectF arg0, float arg1, float arg2, bool arg3, android.graphics.Paint arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawArc", "(Landroid/graphics/RectF;FFZLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual void drawRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual void drawPath(android.graphics.Path arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPath", "(Landroid/graphics/Path;Landroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.RectF arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.Rect arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, float arg3, float arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIFFIIZLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIIIIIZLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Matrix arg1, android.graphics.Paint arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;Landroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, float arg1, float arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;FFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual void drawBitmapMesh(android.graphics.Bitmap arg0, int arg1, int arg2, float[] arg3, int arg4, int[] arg5, int arg6, android.graphics.Paint arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawBitmapMesh", "(Landroid/graphics/Bitmap;II[FI[IILandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual void drawVertices(android.graphics.Canvas.VertexMode arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5, int[] arg6, int arg7, short[] arg8, int arg9, int arg10, android.graphics.Paint arg11)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawVertices", "(Landroid/graphics/Canvas$VertexMode;I[FI[FI[II[SIILandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual void drawText(java.lang.CharSequence arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/CharSequence;IIFFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public void drawText(string arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5)
		{
			drawText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual void drawText(java.lang.String arg0, float arg1, float arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;FFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual void drawText(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawText", "([CIIFFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual void drawText(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;IIFFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public virtual void drawPosText(java.lang.String arg0, float[] arg1, android.graphics.Paint arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPosText", "(Ljava/lang/String;[FLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public virtual void drawPosText(char[] arg0, int arg1, int arg2, float[] arg3, android.graphics.Paint arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPosText", "([CII[FLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public virtual void drawTextOnPath(java.lang.String arg0, android.graphics.Path arg1, float arg2, float arg3, android.graphics.Paint arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawTextOnPath", "(Ljava/lang/String;Landroid/graphics/Path;FFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public virtual void drawTextOnPath(char[] arg0, int arg1, int arg2, android.graphics.Path arg3, float arg4, float arg5, android.graphics.Paint arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawTextOnPath", "([CIILandroid/graphics/Path;FFLandroid/graphics/Paint;)V", ref global::android.graphics.Canvas._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/Rect;)V", ref global::android.graphics.Canvas._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.RectF arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/RectF;)V", ref global::android.graphics.Canvas._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public virtual void drawPicture(android.graphics.Picture arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;)V", ref global::android.graphics.Canvas._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public Canvas(android.graphics.Bitmap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Canvas._m85.native == global::System.IntPtr.Zero)
				global::android.graphics.Canvas._m85 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public Canvas(javax.microedition.khronos.opengles.GL arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Canvas._m86.native == global::System.IntPtr.Zero)
				global::android.graphics.Canvas._m86 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "<init>", "(Ljavax/microedition/khronos/opengles/GL;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m87;
		public Canvas() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Canvas._m87.native == global::System.IntPtr.Zero)
				global::android.graphics.Canvas._m87 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._m87);
			Init(@__env, handle);
		}
		public static int MATRIX_SAVE_FLAG
		{
			get
			{
				return 1;
			}
		}
		public static int CLIP_SAVE_FLAG
		{
			get
			{
				return 2;
			}
		}
		public static int HAS_ALPHA_LAYER_SAVE_FLAG
		{
			get
			{
				return 4;
			}
		}
		public static int FULL_COLOR_LAYER_SAVE_FLAG
		{
			get
			{
				return 8;
			}
		}
		public static int CLIP_TO_LAYER_SAVE_FLAG
		{
			get
			{
				return 16;
			}
		}
		public static int ALL_SAVE_FLAG
		{
			get
			{
				return 31;
			}
		}
		static Canvas()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Canvas.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Canvas"));
		}
		internal static void InitJNI()
		{
		}
	}
}
