namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Canvas : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Canvas()
		{
			InitJNI();
		}
		protected Canvas(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class EdgeType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static EdgeType()
			{
				InitJNI();
			}
			internal EdgeType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5093;
			public static global::android.graphics.Canvas.EdgeType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Canvas.EdgeType>(@__env.CallStaticObjectMethod(android.graphics.Canvas.EdgeType.staticClass, global::android.graphics.Canvas.EdgeType._values5093)) as android.graphics.Canvas.EdgeType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5094;
			public static global::android.graphics.Canvas.EdgeType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.EdgeType>(@__env.CallStaticObjectMethod(android.graphics.Canvas.EdgeType.staticClass, global::android.graphics.Canvas.EdgeType._valueOf5094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas.EdgeType;
			}
			internal static global::MonoJavaBridge.FieldId _AA5095;
			public static global::android.graphics.Canvas.EdgeType AA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.EdgeType>(@__env.GetStaticObjectField(global::android.graphics.Canvas.EdgeType.staticClass, _AA5095)) as android.graphics.Canvas.EdgeType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BW5096;
			public static global::android.graphics.Canvas.EdgeType BW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.EdgeType>(@__env.GetStaticObjectField(global::android.graphics.Canvas.EdgeType.staticClass, _BW5096)) as android.graphics.Canvas.EdgeType;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Canvas.EdgeType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Canvas$EdgeType"));
				global::android.graphics.Canvas.EdgeType._values5093 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "values", "()[Landroid/graphics/Canvas/EdgeType;");
				global::android.graphics.Canvas.EdgeType._valueOf5094 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$EdgeType;");
				global::android.graphics.Canvas.EdgeType._AA5095 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "AA", "Landroid/graphics/Canvas$EdgeType;");
				global::android.graphics.Canvas.EdgeType._BW5096 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "BW", "Landroid/graphics/Canvas$EdgeType;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class VertexMode : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static VertexMode()
			{
				InitJNI();
			}
			internal VertexMode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5097;
			public static global::android.graphics.Canvas.VertexMode[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Canvas.VertexMode>(@__env.CallStaticObjectMethod(android.graphics.Canvas.VertexMode.staticClass, global::android.graphics.Canvas.VertexMode._values5097)) as android.graphics.Canvas.VertexMode[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5098;
			public static global::android.graphics.Canvas.VertexMode valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.VertexMode>(@__env.CallStaticObjectMethod(android.graphics.Canvas.VertexMode.staticClass, global::android.graphics.Canvas.VertexMode._valueOf5098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas.VertexMode;
			}
			internal static global::MonoJavaBridge.FieldId _TRIANGLES5099;
			public static global::android.graphics.Canvas.VertexMode TRIANGLES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.VertexMode>(@__env.GetStaticObjectField(global::android.graphics.Canvas.VertexMode.staticClass, _TRIANGLES5099)) as android.graphics.Canvas.VertexMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TRIANGLE_FAN5100;
			public static global::android.graphics.Canvas.VertexMode TRIANGLE_FAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.VertexMode>(@__env.GetStaticObjectField(global::android.graphics.Canvas.VertexMode.staticClass, _TRIANGLE_FAN5100)) as android.graphics.Canvas.VertexMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TRIANGLE_STRIP5101;
			public static global::android.graphics.Canvas.VertexMode TRIANGLE_STRIP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Canvas.VertexMode>(@__env.GetStaticObjectField(global::android.graphics.Canvas.VertexMode.staticClass, _TRIANGLE_STRIP5101)) as android.graphics.Canvas.VertexMode;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Canvas.VertexMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Canvas$VertexMode"));
				global::android.graphics.Canvas.VertexMode._values5097 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "values", "()[Landroid/graphics/Canvas/VertexMode;");
				global::android.graphics.Canvas.VertexMode._valueOf5098 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$VertexMode;");
				global::android.graphics.Canvas.VertexMode._TRIANGLES5099 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "TRIANGLES", "Landroid/graphics/Canvas$VertexMode;");
				global::android.graphics.Canvas.VertexMode._TRIANGLE_FAN5100 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "TRIANGLE_FAN", "Landroid/graphics/Canvas$VertexMode;");
				global::android.graphics.Canvas.VertexMode._TRIANGLE_STRIP5101 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "TRIANGLE_STRIP", "Landroid/graphics/Canvas$VertexMode;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5102;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._finalize5102);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._finalize5102);
		}
		internal static global::MonoJavaBridge.MethodId _concat5103;
		public virtual void concat(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._concat5103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._concat5103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _save5104;
		public virtual int save() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._save5104);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._save5104);
		}
		internal static global::MonoJavaBridge.MethodId _save5105;
		public virtual int save(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._save5105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._save5105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotate5106;
		public virtual void rotate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._rotate5106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._rotate5106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _rotate5107;
		public virtual void rotate(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._rotate5107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._rotate5107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque5108;
		public virtual bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._isOpaque5108);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._isOpaque5108);
		}
		internal static global::MonoJavaBridge.MethodId _scale5109;
		public virtual void scale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._scale5109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._scale5109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _scale5110;
		public virtual void scale(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._scale5110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._scale5110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getDensity5111;
		public virtual int getDensity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._getDensity5111);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getDensity5111);
		}
		internal static global::MonoJavaBridge.MethodId _setDensity5112;
		public virtual void setDensity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setDensity5112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setDensity5112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth5113;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._getWidth5113);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getWidth5113);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight5114;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._getHeight5114);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getHeight5114);
		}
		public new global::javax.microedition.khronos.opengles.GL GL
		{
			get
			{
				return getGL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGL5115;
		public virtual global::javax.microedition.khronos.opengles.GL getGL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Canvas._getGL5115)) as javax.microedition.khronos.opengles.GL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getGL5115)) as javax.microedition.khronos.opengles.GL;
		}
		internal static global::MonoJavaBridge.MethodId _freeGlCaches5116;
		public static void freeGlCaches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._freeGlCaches5116);
		}
		internal static global::MonoJavaBridge.MethodId _setBitmap5117;
		public virtual void setBitmap(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setBitmap5117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setBitmap5117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setViewport5118;
		public virtual void setViewport(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setViewport5118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setViewport5118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _saveLayer5119;
		public virtual int saveLayer(android.graphics.RectF arg0, android.graphics.Paint arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._saveLayer5119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayer5119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _saveLayer5120;
		public virtual int saveLayer(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._saveLayer5120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayer5120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _saveLayerAlpha5121;
		public virtual int saveLayerAlpha(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._saveLayerAlpha5121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayerAlpha5121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _saveLayerAlpha5122;
		public virtual int saveLayerAlpha(android.graphics.RectF arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._saveLayerAlpha5122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayerAlpha5122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _restore5123;
		public virtual void restore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._restore5123);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._restore5123);
		}
		public new int SaveCount
		{
			get
			{
				return getSaveCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSaveCount5124;
		public virtual int getSaveCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._getSaveCount5124);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getSaveCount5124);
		}
		internal static global::MonoJavaBridge.MethodId _restoreToCount5125;
		public virtual void restoreToCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._restoreToCount5125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._restoreToCount5125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _translate5126;
		public virtual void translate(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._translate5126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._translate5126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _skew5127;
		public virtual void skew(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._skew5127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._skew5127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMatrix5128;
		public virtual void setMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setMatrix5128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setMatrix5128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMatrix5129;
		public virtual global::android.graphics.Matrix getMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Canvas._getMatrix5129)) as android.graphics.Matrix;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getMatrix5129)) as android.graphics.Matrix;
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix5130;
		public virtual void getMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._getMatrix5130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getMatrix5130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect5131;
		public virtual bool clipRect(android.graphics.Rect arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect5131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect5131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect5132;
		public virtual bool clipRect(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect5132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect5132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect5133;
		public virtual bool clipRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect5133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect5133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect5134;
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Region.Op arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect5134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect5134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect5135;
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect5135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect5135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect5136;
		public virtual bool clipRect(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect5136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect5136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect5137;
		public virtual bool clipRect(android.graphics.RectF arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect5137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect5137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clipPath5138;
		public virtual bool clipPath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipPath5138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipPath5138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clipPath5139;
		public virtual bool clipPath(android.graphics.Path arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipPath5139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipPath5139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clipRegion5140;
		public virtual bool clipRegion(android.graphics.Region arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRegion5140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRegion5140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clipRegion5141;
		public virtual bool clipRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRegion5141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRegion5141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDrawFilter5142;
		public virtual global::android.graphics.DrawFilter getDrawFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Canvas._getDrawFilter5142)) as android.graphics.DrawFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getDrawFilter5142)) as android.graphics.DrawFilter;
		}
		internal static global::MonoJavaBridge.MethodId _setDrawFilter5143;
		public virtual void setDrawFilter(android.graphics.DrawFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setDrawFilter5143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setDrawFilter5143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject5144;
		public virtual bool quickReject(android.graphics.RectF arg0, android.graphics.Canvas.EdgeType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._quickReject5144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._quickReject5144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject5145;
		public virtual bool quickReject(android.graphics.Path arg0, android.graphics.Canvas.EdgeType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._quickReject5145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._quickReject5145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject5146;
		public virtual bool quickReject(float arg0, float arg1, float arg2, float arg3, android.graphics.Canvas.EdgeType arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._quickReject5146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._quickReject5146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new global::android.graphics.Rect ClipBounds
		{
			get
			{
				return getClipBounds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClipBounds5147;
		public virtual global::android.graphics.Rect getClipBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Canvas._getClipBounds5147)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getClipBounds5147)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getClipBounds5148;
		public virtual bool getClipBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._getClipBounds5148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getClipBounds5148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawRGB5149;
		public virtual void drawRGB(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRGB5149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRGB5149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawARGB5150;
		public virtual void drawARGB(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawARGB5150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawARGB5150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawColor5151;
		public virtual void drawColor(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawColor5151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawColor5151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawColor5152;
		public virtual void drawColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawColor5152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawColor5152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawPaint5153;
		public virtual void drawPaint(android.graphics.Paint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPaint5153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPaint5153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawPoints5154;
		public virtual void drawPoints(float[] arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPoints5154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPoints5154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawPoints5155;
		public virtual void drawPoints(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPoints5155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPoints5155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawPoint5156;
		public virtual void drawPoint(float arg0, float arg1, android.graphics.Paint arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPoint5156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPoint5156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawLine5157;
		public virtual void drawLine(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawLine5157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawLine5157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawLines5158;
		public virtual void drawLines(float[] arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawLines5158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawLines5158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawLines5159;
		public virtual void drawLines(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawLines5159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawLines5159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawRect5160;
		public virtual void drawRect(android.graphics.Rect arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRect5160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRect5160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawRect5161;
		public virtual void drawRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRect5161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRect5161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawRect5162;
		public virtual void drawRect(android.graphics.RectF arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRect5162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRect5162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawOval5163;
		public virtual void drawOval(android.graphics.RectF arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawOval5163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawOval5163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawCircle5164;
		public virtual void drawCircle(float arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawCircle5164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawCircle5164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawArc5165;
		public virtual void drawArc(android.graphics.RectF arg0, float arg1, float arg2, bool arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawArc5165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawArc5165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawRoundRect5166;
		public virtual void drawRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRoundRect5166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRoundRect5166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawPath5167;
		public virtual void drawPath(android.graphics.Path arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPath5167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPath5167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap5168;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.RectF arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap5168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap5168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap5169;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.Rect arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap5169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap5169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap5170;
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, float arg3, float arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap5170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap5170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap5171;
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap5171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap5171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap5172;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Matrix arg1, android.graphics.Paint arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap5172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap5172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap5173;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap5173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap5173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmapMesh5174;
		public virtual void drawBitmapMesh(android.graphics.Bitmap arg0, int arg1, int arg2, float[] arg3, int arg4, int[] arg5, int arg6, android.graphics.Paint arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmapMesh5174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmapMesh5174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _drawVertices5175;
		public virtual void drawVertices(android.graphics.Canvas.VertexMode arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5, int[] arg6, int arg7, short[] arg8, int arg9, int arg10, android.graphics.Paint arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawVertices5175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawVertices5175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		internal static global::MonoJavaBridge.MethodId _drawText5176;
		public virtual void drawText(java.lang.CharSequence arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawText5176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText5176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public void drawText(string arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5)
		{
			drawText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _drawText5177;
		public virtual void drawText(java.lang.String arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawText5177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText5177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawText5178;
		public virtual void drawText(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawText5178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText5178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _drawText5179;
		public virtual void drawText(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawText5179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText5179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _drawPosText5180;
		public virtual void drawPosText(java.lang.String arg0, float[] arg1, android.graphics.Paint arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPosText5180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPosText5180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawPosText5181;
		public virtual void drawPosText(char[] arg0, int arg1, int arg2, float[] arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPosText5181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPosText5181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawTextOnPath5182;
		public virtual void drawTextOnPath(java.lang.String arg0, android.graphics.Path arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawTextOnPath5182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawTextOnPath5182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawTextOnPath5183;
		public virtual void drawTextOnPath(char[] arg0, int arg1, int arg2, android.graphics.Path arg3, float arg4, float arg5, android.graphics.Paint arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawTextOnPath5183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawTextOnPath5183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _drawPicture5184;
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPicture5184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPicture5184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawPicture5185;
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPicture5185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPicture5185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawPicture5186;
		public virtual void drawPicture(android.graphics.Picture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPicture5186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPicture5186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Canvas5187;
		public Canvas(android.graphics.Bitmap arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._Canvas5187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Canvas5188;
		public Canvas(javax.microedition.khronos.opengles.GL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._Canvas5188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Canvas5189;
		public Canvas()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._Canvas5189);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Canvas.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Canvas"));
			global::android.graphics.Canvas._finalize5102 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "finalize", "()V");
			global::android.graphics.Canvas._concat5103 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "concat", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Canvas._save5104 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "save", "()I");
			global::android.graphics.Canvas._save5105 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "save", "(I)I");
			global::android.graphics.Canvas._rotate5106 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "rotate", "(FFF)V");
			global::android.graphics.Canvas._rotate5107 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "rotate", "(F)V");
			global::android.graphics.Canvas._isOpaque5108 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "isOpaque", "()Z");
			global::android.graphics.Canvas._scale5109 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "scale", "(FFFF)V");
			global::android.graphics.Canvas._scale5110 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "scale", "(FF)V");
			global::android.graphics.Canvas._getDensity5111 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getDensity", "()I");
			global::android.graphics.Canvas._setDensity5112 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setDensity", "(I)V");
			global::android.graphics.Canvas._getWidth5113 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getWidth", "()I");
			global::android.graphics.Canvas._getHeight5114 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getHeight", "()I");
			global::android.graphics.Canvas._getGL5115 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;");
			global::android.graphics.Canvas._freeGlCaches5116 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "freeGlCaches", "()V");
			global::android.graphics.Canvas._setBitmap5117 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.Canvas._setViewport5118 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setViewport", "(II)V");
			global::android.graphics.Canvas._saveLayer5119 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "saveLayer", "(Landroid/graphics/RectF;Landroid/graphics/Paint;I)I");
			global::android.graphics.Canvas._saveLayer5120 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "saveLayer", "(FFFFLandroid/graphics/Paint;I)I");
			global::android.graphics.Canvas._saveLayerAlpha5121 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(FFFFII)I");
			global::android.graphics.Canvas._saveLayerAlpha5122 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(Landroid/graphics/RectF;II)I");
			global::android.graphics.Canvas._restore5123 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "restore", "()V");
			global::android.graphics.Canvas._getSaveCount5124 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getSaveCount", "()I");
			global::android.graphics.Canvas._restoreToCount5125 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "restoreToCount", "(I)V");
			global::android.graphics.Canvas._translate5126 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "translate", "(FF)V");
			global::android.graphics.Canvas._skew5127 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "skew", "(FF)V");
			global::android.graphics.Canvas._setMatrix5128 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Canvas._getMatrix5129 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getMatrix", "()Landroid/graphics/Matrix;");
			global::android.graphics.Canvas._getMatrix5130 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Canvas._clipRect5131 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRect5132 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Canvas._clipRect5133 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Canvas._clipRect5134 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(FFFFLandroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRect5135 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(FFFF)Z");
			global::android.graphics.Canvas._clipRect5136 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(IIII)Z");
			global::android.graphics.Canvas._clipRect5137 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipPath5138 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;)Z");
			global::android.graphics.Canvas._clipPath5139 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRegion5140 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRegion5141 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Canvas._getDrawFilter5142 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getDrawFilter", "()Landroid/graphics/DrawFilter;");
			global::android.graphics.Canvas._setDrawFilter5143 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setDrawFilter", "(Landroid/graphics/DrawFilter;)V");
			global::android.graphics.Canvas._quickReject5144 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/RectF;Landroid/graphics/Canvas$EdgeType;)Z");
			global::android.graphics.Canvas._quickReject5145 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/Path;Landroid/graphics/Canvas$EdgeType;)Z");
			global::android.graphics.Canvas._quickReject5146 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "quickReject", "(FFFFLandroid/graphics/Canvas$EdgeType;)Z");
			global::android.graphics.Canvas._getClipBounds5147 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getClipBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.Canvas._getClipBounds5148 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getClipBounds", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Canvas._drawRGB5149 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRGB", "(III)V");
			global::android.graphics.Canvas._drawARGB5150 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawARGB", "(IIII)V");
			global::android.graphics.Canvas._drawColor5151 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawColor", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.graphics.Canvas._drawColor5152 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawColor", "(I)V");
			global::android.graphics.Canvas._drawPaint5153 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPaint", "(Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPoints5154 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPoints", "([FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPoints5155 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPoints", "([FIILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPoint5156 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPoint", "(FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawLine5157 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawLine", "(FFFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawLines5158 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawLines", "([FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawLines5159 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawLines", "([FIILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRect5160 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRect5161 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRect", "(FFFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRect5162 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawOval5163 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawOval", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawCircle5164 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawCircle", "(FFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawArc5165 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawArc", "(Landroid/graphics/RectF;FFZLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRoundRect5166 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPath5167 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPath", "(Landroid/graphics/Path;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap5168 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap5169 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap5170 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIFFIIZLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap5171 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIIIIIZLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap5172 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap5173 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmapMesh5174 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmapMesh", "(Landroid/graphics/Bitmap;II[FI[IILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawVertices5175 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawVertices", "(Landroid/graphics/Canvas$VertexMode;I[FI[FI[II[SIILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText5176 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/CharSequence;IIFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText5177 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText5178 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawText", "([CIIFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText5179 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;IIFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPosText5180 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPosText", "(Ljava/lang/String;[FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPosText5181 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPosText", "([CII[FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawTextOnPath5182 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawTextOnPath", "(Ljava/lang/String;Landroid/graphics/Path;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawTextOnPath5183 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawTextOnPath", "([CIILandroid/graphics/Path;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPicture5184 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/Rect;)V");
			global::android.graphics.Canvas._drawPicture5185 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/RectF;)V");
			global::android.graphics.Canvas._drawPicture5186 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;)V");
			global::android.graphics.Canvas._Canvas5187 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.Canvas._Canvas5188 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "<init>", "(Ljavax/microedition/khronos/opengles/GL;)V");
			global::android.graphics.Canvas._Canvas5189 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "<init>", "()V");
		}
	}
}
