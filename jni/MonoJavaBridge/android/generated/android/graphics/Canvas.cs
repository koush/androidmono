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
			internal static global::MonoJavaBridge.MethodId _values3174;
			public static global::android.graphics.Canvas.EdgeType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Canvas.EdgeType>(@__env.CallStaticObjectMethod(android.graphics.Canvas.EdgeType.staticClass, global::android.graphics.Canvas.EdgeType._values3174)) as android.graphics.Canvas.EdgeType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3175;
			public static global::android.graphics.Canvas.EdgeType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Canvas.EdgeType.staticClass, global::android.graphics.Canvas.EdgeType._valueOf3175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas.EdgeType;
			}
			internal static global::MonoJavaBridge.FieldId _AA3176;
			public static global::android.graphics.Canvas.EdgeType AA
			{
				get
				{
					return default(global::android.graphics.Canvas.EdgeType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BW3177;
			public static global::android.graphics.Canvas.EdgeType BW
			{
				get
				{
					return default(global::android.graphics.Canvas.EdgeType);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Canvas.EdgeType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Canvas$EdgeType"));
				global::android.graphics.Canvas.EdgeType._values3174 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "values", "()[Landroid/graphics/Canvas/EdgeType;");
				global::android.graphics.Canvas.EdgeType._valueOf3175 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.EdgeType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$EdgeType;");
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
			internal static global::MonoJavaBridge.MethodId _values3178;
			public static global::android.graphics.Canvas.VertexMode[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Canvas.VertexMode>(@__env.CallStaticObjectMethod(android.graphics.Canvas.VertexMode.staticClass, global::android.graphics.Canvas.VertexMode._values3178)) as android.graphics.Canvas.VertexMode[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3179;
			public static global::android.graphics.Canvas.VertexMode valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Canvas.VertexMode.staticClass, global::android.graphics.Canvas.VertexMode._valueOf3179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas.VertexMode;
			}
			internal static global::MonoJavaBridge.FieldId _TRIANGLES3180;
			public static global::android.graphics.Canvas.VertexMode TRIANGLES
			{
				get
				{
					return default(global::android.graphics.Canvas.VertexMode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TRIANGLE_FAN3181;
			public static global::android.graphics.Canvas.VertexMode TRIANGLE_FAN
			{
				get
				{
					return default(global::android.graphics.Canvas.VertexMode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TRIANGLE_STRIP3182;
			public static global::android.graphics.Canvas.VertexMode TRIANGLE_STRIP
			{
				get
				{
					return default(global::android.graphics.Canvas.VertexMode);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Canvas.VertexMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Canvas$VertexMode"));
				global::android.graphics.Canvas.VertexMode._values3178 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "values", "()[Landroid/graphics/Canvas/VertexMode;");
				global::android.graphics.Canvas.VertexMode._valueOf3179 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.VertexMode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$VertexMode;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize3183;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._finalize3183);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._finalize3183);
		}
		internal static global::MonoJavaBridge.MethodId _concat3184;
		public virtual void concat(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._concat3184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._concat3184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _save3185;
		public virtual int save() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._save3185);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._save3185);
		}
		internal static global::MonoJavaBridge.MethodId _save3186;
		public virtual int save(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._save3186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._save3186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotate3187;
		public virtual void rotate(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._rotate3187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._rotate3187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _rotate3188;
		public virtual void rotate(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._rotate3188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._rotate3188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque3189;
		public virtual bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._isOpaque3189);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._isOpaque3189);
		}
		internal static global::MonoJavaBridge.MethodId _scale3190;
		public virtual void scale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._scale3190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._scale3190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _scale3191;
		public virtual void scale(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._scale3191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._scale3191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getDensity3192;
		public virtual int getDensity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._getDensity3192);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getDensity3192);
		}
		internal static global::MonoJavaBridge.MethodId _setDensity3193;
		public virtual void setDensity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setDensity3193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setDensity3193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth3194;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._getWidth3194);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getWidth3194);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight3195;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._getHeight3195);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getHeight3195);
		}
		public new global::javax.microedition.khronos.opengles.GL GL
		{
			get
			{
				return getGL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGL3196;
		public virtual global::javax.microedition.khronos.opengles.GL getGL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Canvas._getGL3196)) as javax.microedition.khronos.opengles.GL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getGL3196)) as javax.microedition.khronos.opengles.GL;
		}
		internal static global::MonoJavaBridge.MethodId _freeGlCaches3197;
		public static void freeGlCaches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._freeGlCaches3197);
		}
		internal static global::MonoJavaBridge.MethodId _setBitmap3198;
		public virtual void setBitmap(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setBitmap3198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setBitmap3198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setViewport3199;
		public virtual void setViewport(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setViewport3199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setViewport3199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _saveLayer3200;
		public virtual int saveLayer(android.graphics.RectF arg0, android.graphics.Paint arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._saveLayer3200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayer3200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _saveLayer3201;
		public virtual int saveLayer(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._saveLayer3201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayer3201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _saveLayerAlpha3202;
		public virtual int saveLayerAlpha(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._saveLayerAlpha3202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayerAlpha3202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _saveLayerAlpha3203;
		public virtual int saveLayerAlpha(android.graphics.RectF arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._saveLayerAlpha3203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayerAlpha3203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _restore3204;
		public virtual void restore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._restore3204);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._restore3204);
		}
		public new int SaveCount
		{
			get
			{
				return getSaveCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSaveCount3205;
		public virtual int getSaveCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Canvas._getSaveCount3205);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getSaveCount3205);
		}
		internal static global::MonoJavaBridge.MethodId _restoreToCount3206;
		public virtual void restoreToCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._restoreToCount3206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._restoreToCount3206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _translate3207;
		public virtual void translate(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._translate3207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._translate3207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _skew3208;
		public virtual void skew(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._skew3208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._skew3208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMatrix3209;
		public virtual void setMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setMatrix3209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setMatrix3209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMatrix3210;
		public virtual global::android.graphics.Matrix getMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Canvas._getMatrix3210)) as android.graphics.Matrix;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getMatrix3210)) as android.graphics.Matrix;
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix3211;
		public virtual void getMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._getMatrix3211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getMatrix3211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect3212;
		public virtual bool clipRect(android.graphics.Rect arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect3212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect3212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect3213;
		public virtual bool clipRect(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect3213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect3213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect3214;
		public virtual bool clipRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect3214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect3214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect3215;
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Region.Op arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect3215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect3215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect3216;
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect3216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect3216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect3217;
		public virtual bool clipRect(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect3217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect3217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clipRect3218;
		public virtual bool clipRect(android.graphics.RectF arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRect3218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect3218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clipPath3219;
		public virtual bool clipPath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipPath3219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipPath3219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clipPath3220;
		public virtual bool clipPath(android.graphics.Path arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipPath3220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipPath3220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clipRegion3221;
		public virtual bool clipRegion(android.graphics.Region arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRegion3221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRegion3221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clipRegion3222;
		public virtual bool clipRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._clipRegion3222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRegion3222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDrawFilter3223;
		public virtual global::android.graphics.DrawFilter getDrawFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Canvas._getDrawFilter3223)) as android.graphics.DrawFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getDrawFilter3223)) as android.graphics.DrawFilter;
		}
		internal static global::MonoJavaBridge.MethodId _setDrawFilter3224;
		public virtual void setDrawFilter(android.graphics.DrawFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._setDrawFilter3224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setDrawFilter3224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject3225;
		public virtual bool quickReject(android.graphics.RectF arg0, android.graphics.Canvas.EdgeType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._quickReject3225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._quickReject3225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject3226;
		public virtual bool quickReject(android.graphics.Path arg0, android.graphics.Canvas.EdgeType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._quickReject3226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._quickReject3226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject3227;
		public virtual bool quickReject(float arg0, float arg1, float arg2, float arg3, android.graphics.Canvas.EdgeType arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._quickReject3227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._quickReject3227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new global::android.graphics.Rect ClipBounds
		{
			get
			{
				return getClipBounds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClipBounds3228;
		public virtual global::android.graphics.Rect getClipBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Canvas._getClipBounds3228)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getClipBounds3228)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getClipBounds3229;
		public virtual bool getClipBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Canvas._getClipBounds3229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getClipBounds3229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawRGB3230;
		public virtual void drawRGB(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRGB3230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRGB3230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawARGB3231;
		public virtual void drawARGB(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawARGB3231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawARGB3231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawColor3232;
		public virtual void drawColor(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawColor3232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawColor3232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawColor3233;
		public virtual void drawColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawColor3233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawColor3233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawPaint3234;
		public virtual void drawPaint(android.graphics.Paint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPaint3234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPaint3234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawPoints3235;
		public virtual void drawPoints(float[] arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPoints3235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPoints3235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawPoints3236;
		public virtual void drawPoints(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPoints3236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPoints3236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawPoint3237;
		public virtual void drawPoint(float arg0, float arg1, android.graphics.Paint arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPoint3237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPoint3237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawLine3238;
		public virtual void drawLine(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawLine3238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawLine3238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawLines3239;
		public virtual void drawLines(float[] arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawLines3239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawLines3239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawLines3240;
		public virtual void drawLines(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawLines3240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawLines3240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawRect3241;
		public virtual void drawRect(android.graphics.Rect arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRect3241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRect3241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawRect3242;
		public virtual void drawRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRect3242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRect3242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawRect3243;
		public virtual void drawRect(android.graphics.RectF arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRect3243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRect3243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawOval3244;
		public virtual void drawOval(android.graphics.RectF arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawOval3244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawOval3244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawCircle3245;
		public virtual void drawCircle(float arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawCircle3245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawCircle3245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawArc3246;
		public virtual void drawArc(android.graphics.RectF arg0, float arg1, float arg2, bool arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawArc3246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawArc3246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawRoundRect3247;
		public virtual void drawRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawRoundRect3247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRoundRect3247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawPath3248;
		public virtual void drawPath(android.graphics.Path arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPath3248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPath3248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap3249;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.RectF arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap3249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap3249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap3250;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.Rect arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap3250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap3250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap3251;
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, float arg3, float arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap3251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap3251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap3252;
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap3252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap3252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap3253;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Matrix arg1, android.graphics.Paint arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap3253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap3253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmap3254;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmap3254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap3254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawBitmapMesh3255;
		public virtual void drawBitmapMesh(android.graphics.Bitmap arg0, int arg1, int arg2, float[] arg3, int arg4, int[] arg5, int arg6, android.graphics.Paint arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawBitmapMesh3255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmapMesh3255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _drawVertices3256;
		public virtual void drawVertices(android.graphics.Canvas.VertexMode arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5, int[] arg6, int arg7, short[] arg8, int arg9, int arg10, android.graphics.Paint arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawVertices3256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawVertices3256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		internal static global::MonoJavaBridge.MethodId _drawText3257;
		public virtual void drawText(java.lang.CharSequence arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawText3257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText3257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public void drawText(string arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5)
		{
			drawText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _drawText3258;
		public virtual void drawText(java.lang.String arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawText3258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText3258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drawText3259;
		public virtual void drawText(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawText3259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText3259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _drawText3260;
		public virtual void drawText(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawText3260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText3260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _drawPosText3261;
		public virtual void drawPosText(java.lang.String arg0, float[] arg1, android.graphics.Paint arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPosText3261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPosText3261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawPosText3262;
		public virtual void drawPosText(char[] arg0, int arg1, int arg2, float[] arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPosText3262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPosText3262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawTextOnPath3263;
		public virtual void drawTextOnPath(java.lang.String arg0, android.graphics.Path arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawTextOnPath3263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawTextOnPath3263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _drawTextOnPath3264;
		public virtual void drawTextOnPath(char[] arg0, int arg1, int arg2, android.graphics.Path arg3, float arg4, float arg5, android.graphics.Paint arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawTextOnPath3264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawTextOnPath3264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _drawPicture3265;
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPicture3265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPicture3265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawPicture3266;
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPicture3266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPicture3266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawPicture3267;
		public virtual void drawPicture(android.graphics.Picture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Canvas._drawPicture3267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPicture3267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Canvas3268;
		public Canvas(android.graphics.Bitmap arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._Canvas3268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Canvas3269;
		public Canvas(javax.microedition.khronos.opengles.GL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._Canvas3269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Canvas3270;
		public Canvas()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._Canvas3270);
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
			global::android.graphics.Canvas._finalize3183 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "finalize", "()V");
			global::android.graphics.Canvas._concat3184 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "concat", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Canvas._save3185 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "save", "()I");
			global::android.graphics.Canvas._save3186 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "save", "(I)I");
			global::android.graphics.Canvas._rotate3187 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "rotate", "(FFF)V");
			global::android.graphics.Canvas._rotate3188 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "rotate", "(F)V");
			global::android.graphics.Canvas._isOpaque3189 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "isOpaque", "()Z");
			global::android.graphics.Canvas._scale3190 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "scale", "(FFFF)V");
			global::android.graphics.Canvas._scale3191 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "scale", "(FF)V");
			global::android.graphics.Canvas._getDensity3192 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getDensity", "()I");
			global::android.graphics.Canvas._setDensity3193 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setDensity", "(I)V");
			global::android.graphics.Canvas._getWidth3194 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getWidth", "()I");
			global::android.graphics.Canvas._getHeight3195 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getHeight", "()I");
			global::android.graphics.Canvas._getGL3196 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;");
			global::android.graphics.Canvas._freeGlCaches3197 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "freeGlCaches", "()V");
			global::android.graphics.Canvas._setBitmap3198 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.Canvas._setViewport3199 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setViewport", "(II)V");
			global::android.graphics.Canvas._saveLayer3200 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "saveLayer", "(Landroid/graphics/RectF;Landroid/graphics/Paint;I)I");
			global::android.graphics.Canvas._saveLayer3201 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "saveLayer", "(FFFFLandroid/graphics/Paint;I)I");
			global::android.graphics.Canvas._saveLayerAlpha3202 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(FFFFII)I");
			global::android.graphics.Canvas._saveLayerAlpha3203 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(Landroid/graphics/RectF;II)I");
			global::android.graphics.Canvas._restore3204 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "restore", "()V");
			global::android.graphics.Canvas._getSaveCount3205 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getSaveCount", "()I");
			global::android.graphics.Canvas._restoreToCount3206 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "restoreToCount", "(I)V");
			global::android.graphics.Canvas._translate3207 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "translate", "(FF)V");
			global::android.graphics.Canvas._skew3208 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "skew", "(FF)V");
			global::android.graphics.Canvas._setMatrix3209 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Canvas._getMatrix3210 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getMatrix", "()Landroid/graphics/Matrix;");
			global::android.graphics.Canvas._getMatrix3211 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Canvas._clipRect3212 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRect3213 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Canvas._clipRect3214 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Canvas._clipRect3215 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(FFFFLandroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRect3216 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(FFFF)Z");
			global::android.graphics.Canvas._clipRect3217 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(IIII)Z");
			global::android.graphics.Canvas._clipRect3218 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipPath3219 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;)Z");
			global::android.graphics.Canvas._clipPath3220 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRegion3221 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRegion3222 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Canvas._getDrawFilter3223 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getDrawFilter", "()Landroid/graphics/DrawFilter;");
			global::android.graphics.Canvas._setDrawFilter3224 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "setDrawFilter", "(Landroid/graphics/DrawFilter;)V");
			global::android.graphics.Canvas._quickReject3225 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/RectF;Landroid/graphics/Canvas$EdgeType;)Z");
			global::android.graphics.Canvas._quickReject3226 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/Path;Landroid/graphics/Canvas$EdgeType;)Z");
			global::android.graphics.Canvas._quickReject3227 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "quickReject", "(FFFFLandroid/graphics/Canvas$EdgeType;)Z");
			global::android.graphics.Canvas._getClipBounds3228 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getClipBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.Canvas._getClipBounds3229 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "getClipBounds", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Canvas._drawRGB3230 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRGB", "(III)V");
			global::android.graphics.Canvas._drawARGB3231 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawARGB", "(IIII)V");
			global::android.graphics.Canvas._drawColor3232 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawColor", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.graphics.Canvas._drawColor3233 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawColor", "(I)V");
			global::android.graphics.Canvas._drawPaint3234 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPaint", "(Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPoints3235 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPoints", "([FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPoints3236 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPoints", "([FIILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPoint3237 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPoint", "(FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawLine3238 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawLine", "(FFFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawLines3239 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawLines", "([FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawLines3240 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawLines", "([FIILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRect3241 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRect3242 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRect", "(FFFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRect3243 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawOval3244 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawOval", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawCircle3245 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawCircle", "(FFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawArc3246 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawArc", "(Landroid/graphics/RectF;FFZLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRoundRect3247 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPath3248 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPath", "(Landroid/graphics/Path;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap3249 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap3250 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap3251 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIFFIIZLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap3252 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIIIIIZLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap3253 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap3254 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmapMesh3255 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawBitmapMesh", "(Landroid/graphics/Bitmap;II[FI[IILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawVertices3256 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawVertices", "(Landroid/graphics/Canvas$VertexMode;I[FI[FI[II[SIILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText3257 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/CharSequence;IIFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText3258 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText3259 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawText", "([CIIFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText3260 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;IIFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPosText3261 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPosText", "(Ljava/lang/String;[FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPosText3262 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPosText", "([CII[FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawTextOnPath3263 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawTextOnPath", "(Ljava/lang/String;Landroid/graphics/Path;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawTextOnPath3264 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawTextOnPath", "([CIILandroid/graphics/Path;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPicture3265 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/Rect;)V");
			global::android.graphics.Canvas._drawPicture3266 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/RectF;)V");
			global::android.graphics.Canvas._drawPicture3267 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;)V");
			global::android.graphics.Canvas._Canvas3268 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.Canvas._Canvas3269 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "<init>", "(Ljavax/microedition/khronos/opengles/GL;)V");
			global::android.graphics.Canvas._Canvas3270 = @__env.GetMethodIDNoThrow(global::android.graphics.Canvas.staticClass, "<init>", "()V");
		}
	}
}
