namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Canvas : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Canvas()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Canvas), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Canvas(@__env);
			}
		}
		protected Canvas(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class EdgeType : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static EdgeType()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Canvas.EdgeType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.Canvas.EdgeType(@__env);
				}
			}
			internal EdgeType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2802;
			public static global::android.graphics.Canvas.EdgeType valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas.EdgeType>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Canvas.EdgeType.staticClass, global::android.graphics.Canvas.EdgeType._valueOf2802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _values2803;
			public static global::android.graphics.Canvas.EdgeType[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Canvas.EdgeType.staticClass, global::android.graphics.Canvas.EdgeType._values2803));
			}
			internal static global::net.sf.jni4net.jni.FieldId _AA2804;
			public static global::android.graphics.Canvas.EdgeType AA
			{
				get
				{
					return default(global::android.graphics.Canvas.EdgeType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _BW2805;
			public static global::android.graphics.Canvas.EdgeType BW
			{
				get
				{
					return default(global::android.graphics.Canvas.EdgeType);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.Canvas.EdgeType.staticClass = @__class;
				global::android.graphics.Canvas.EdgeType._valueOf2802 = @__env.GetStaticMethodID(global::android.graphics.Canvas.EdgeType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$EdgeType;");
				global::android.graphics.Canvas.EdgeType._values2803 = @__env.GetStaticMethodID(global::android.graphics.Canvas.EdgeType.staticClass, "values", "()[Landroid/graphics/Canvas/EdgeType;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class VertexMode : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static VertexMode()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Canvas.VertexMode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.Canvas.VertexMode(@__env);
				}
			}
			internal VertexMode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2806;
			public static global::android.graphics.Canvas.VertexMode valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas.VertexMode>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Canvas.VertexMode.staticClass, global::android.graphics.Canvas.VertexMode._valueOf2806, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _values2807;
			public static global::android.graphics.Canvas.VertexMode[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Canvas.VertexMode.staticClass, global::android.graphics.Canvas.VertexMode._values2807));
			}
			internal static global::net.sf.jni4net.jni.FieldId _TRIANGLES2808;
			public static global::android.graphics.Canvas.VertexMode TRIANGLES
			{
				get
				{
					return default(global::android.graphics.Canvas.VertexMode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TRIANGLE_FAN2809;
			public static global::android.graphics.Canvas.VertexMode TRIANGLE_FAN
			{
				get
				{
					return default(global::android.graphics.Canvas.VertexMode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TRIANGLE_STRIP2810;
			public static global::android.graphics.Canvas.VertexMode TRIANGLE_STRIP
			{
				get
				{
					return default(global::android.graphics.Canvas.VertexMode);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.Canvas.VertexMode.staticClass = @__class;
				global::android.graphics.Canvas.VertexMode._valueOf2806 = @__env.GetStaticMethodID(global::android.graphics.Canvas.VertexMode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$VertexMode;");
				global::android.graphics.Canvas.VertexMode._values2807 = @__env.GetStaticMethodID(global::android.graphics.Canvas.VertexMode.staticClass, "values", "()[Landroid/graphics/Canvas/VertexMode;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _concat2811;
		public virtual void concat(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._concat2811, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._concat2811, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _save2812;
		public virtual int save() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._save2812);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._save2812);
		}
		internal static global::net.sf.jni4net.jni.MethodId _save2813;
		public virtual int save(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._save2813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._save2813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rotate2814;
		public virtual void rotate(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._rotate2814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._rotate2814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rotate2815;
		public virtual void rotate(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._rotate2815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._rotate2815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque2816;
		public virtual bool isOpaque() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._isOpaque2816);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._isOpaque2816);
		}
		internal static global::net.sf.jni4net.jni.MethodId _scale2817;
		public virtual void scale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._scale2817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._scale2817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scale2818;
		public virtual void scale(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._scale2818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._scale2818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDensity2819;
		public virtual int getDensity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._getDensity2819);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getDensity2819);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDensity2820;
		public virtual void setDensity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._setDensity2820, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setDensity2820, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth2821;
		public virtual int getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._getWidth2821);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getWidth2821);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight2822;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._getHeight2822);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getHeight2822);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGL2823;
		public virtual global::javax.microedition.khronos.opengles.GL getGL() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.microedition.khronos.opengles.GL>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Canvas._getGL2823));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.microedition.khronos.opengles.GL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getGL2823));
		}
		internal static global::net.sf.jni4net.jni.MethodId _freeGlCaches2824;
		public static void freeGlCaches() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._freeGlCaches2824);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBitmap2825;
		public virtual void setBitmap(android.graphics.Bitmap arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._setBitmap2825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setBitmap2825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewport2826;
		public virtual void setViewport(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._setViewport2826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setViewport2826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _saveLayer2827;
		public virtual int saveLayer(android.graphics.RectF arg0, android.graphics.Paint arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._saveLayer2827, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayer2827, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _saveLayer2828;
		public virtual int saveLayer(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._saveLayer2828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayer2828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _saveLayerAlpha2829;
		public virtual int saveLayerAlpha(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._saveLayerAlpha2829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayerAlpha2829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _saveLayerAlpha2830;
		public virtual int saveLayerAlpha(android.graphics.RectF arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._saveLayerAlpha2830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._saveLayerAlpha2830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restore2831;
		public virtual void restore() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._restore2831);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._restore2831);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSaveCount2832;
		public virtual int getSaveCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Canvas._getSaveCount2832);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getSaveCount2832);
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreToCount2833;
		public virtual void restoreToCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._restoreToCount2833, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._restoreToCount2833, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _translate2834;
		public virtual void translate(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._translate2834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._translate2834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _skew2835;
		public virtual void skew(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._skew2835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._skew2835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMatrix2836;
		public virtual void setMatrix(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._setMatrix2836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setMatrix2836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix2837;
		public virtual global::android.graphics.Matrix getMatrix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Canvas._getMatrix2837));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getMatrix2837));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix2838;
		public virtual void getMatrix(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._getMatrix2838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getMatrix2838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2839;
		public virtual bool clipRect(android.graphics.Rect arg0, android.graphics.Region.Op arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipRect2839, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect2839, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2840;
		public virtual bool clipRect(android.graphics.RectF arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipRect2840, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect2840, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2841;
		public virtual bool clipRect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipRect2841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect2841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2842;
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Region.Op arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipRect2842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect2842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2843;
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipRect2843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect2843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2844;
		public virtual bool clipRect(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipRect2844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect2844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2845;
		public virtual bool clipRect(android.graphics.RectF arg0, android.graphics.Region.Op arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipRect2845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRect2845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipPath2846;
		public virtual bool clipPath(android.graphics.Path arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipPath2846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipPath2846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipPath2847;
		public virtual bool clipPath(android.graphics.Path arg0, android.graphics.Region.Op arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipPath2847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipPath2847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipRegion2848;
		public virtual bool clipRegion(android.graphics.Region arg0, android.graphics.Region.Op arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipRegion2848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRegion2848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clipRegion2849;
		public virtual bool clipRegion(android.graphics.Region arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._clipRegion2849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._clipRegion2849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawFilter2850;
		public virtual global::android.graphics.DrawFilter getDrawFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.DrawFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Canvas._getDrawFilter2850));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.DrawFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getDrawFilter2850));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDrawFilter2851;
		public virtual void setDrawFilter(android.graphics.DrawFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._setDrawFilter2851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._setDrawFilter2851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickReject2852;
		public virtual bool quickReject(android.graphics.RectF arg0, android.graphics.Canvas.EdgeType arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._quickReject2852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._quickReject2852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickReject2853;
		public virtual bool quickReject(android.graphics.Path arg0, android.graphics.Canvas.EdgeType arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._quickReject2853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._quickReject2853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickReject2854;
		public virtual bool quickReject(float arg0, float arg1, float arg2, float arg3, android.graphics.Canvas.EdgeType arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._quickReject2854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._quickReject2854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getClipBounds2855;
		public virtual global::android.graphics.Rect getClipBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Canvas._getClipBounds2855));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getClipBounds2855));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getClipBounds2856;
		public virtual bool getClipBounds(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Canvas._getClipBounds2856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._getClipBounds2856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawRGB2857;
		public virtual void drawRGB(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawRGB2857, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRGB2857, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawARGB2858;
		public virtual void drawARGB(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawARGB2858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawARGB2858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawColor2859;
		public virtual void drawColor(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawColor2859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawColor2859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawColor2860;
		public virtual void drawColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawColor2860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawColor2860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPaint2861;
		public virtual void drawPaint(android.graphics.Paint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPaint2861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPaint2861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPoints2862;
		public virtual void drawPoints(float[] arg0, android.graphics.Paint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPoints2862, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPoints2862, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPoints2863;
		public virtual void drawPoints(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPoints2863, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPoints2863, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPoint2864;
		public virtual void drawPoint(float arg0, float arg1, android.graphics.Paint arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPoint2864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPoint2864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawLine2865;
		public virtual void drawLine(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawLine2865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawLine2865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawLines2866;
		public virtual void drawLines(float[] arg0, android.graphics.Paint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawLines2866, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawLines2866, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawLines2867;
		public virtual void drawLines(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawLines2867, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawLines2867, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawRect2868;
		public virtual void drawRect(android.graphics.Rect arg0, android.graphics.Paint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawRect2868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRect2868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawRect2869;
		public virtual void drawRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawRect2869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRect2869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawRect2870;
		public virtual void drawRect(android.graphics.RectF arg0, android.graphics.Paint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawRect2870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRect2870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawOval2871;
		public virtual void drawOval(android.graphics.RectF arg0, android.graphics.Paint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawOval2871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawOval2871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawCircle2872;
		public virtual void drawCircle(float arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawCircle2872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawCircle2872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawArc2873;
		public virtual void drawArc(android.graphics.RectF arg0, float arg1, float arg2, bool arg3, android.graphics.Paint arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawArc2873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawArc2873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawRoundRect2874;
		public virtual void drawRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawRoundRect2874, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawRoundRect2874, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPath2875;
		public virtual void drawPath(android.graphics.Path arg0, android.graphics.Paint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPath2875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPath2875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2876;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.RectF arg2, android.graphics.Paint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawBitmap2876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap2876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2877;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.Rect arg2, android.graphics.Paint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawBitmap2877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap2877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2878;
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, float arg3, float arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawBitmap2878, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap2878, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2879;
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawBitmap2879, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap2879, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2880;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Matrix arg1, android.graphics.Paint arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawBitmap2880, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap2880, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2881;
		public virtual void drawBitmap(android.graphics.Bitmap arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawBitmap2881, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmap2881, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmapMesh2882;
		public virtual void drawBitmapMesh(android.graphics.Bitmap arg0, int arg1, int arg2, float[] arg3, int arg4, int[] arg5, int arg6, android.graphics.Paint arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawBitmapMesh2882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawBitmapMesh2882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawVertices2883;
		public virtual void drawVertices(android.graphics.Canvas.VertexMode arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5, int[] arg6, int arg7, short[] arg8, int arg9, int arg10, android.graphics.Paint arg11) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawVertices2883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawVertices2883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawText2884;
		public virtual void drawText(java.lang.CharSequence arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawText2884, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText2884, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		public void drawText(string arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5)
		{
			drawText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawText2885;
		public virtual void drawText(java.lang.String arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawText2885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText2885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawText2886;
		public virtual void drawText(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawText2886, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText2886, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawText2887;
		public virtual void drawText(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawText2887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawText2887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPosText2888;
		public virtual void drawPosText(java.lang.String arg0, float[] arg1, android.graphics.Paint arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPosText2888, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPosText2888, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPosText2889;
		public virtual void drawPosText(char[] arg0, int arg1, int arg2, float[] arg3, android.graphics.Paint arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPosText2889, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPosText2889, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawTextOnPath2890;
		public virtual void drawTextOnPath(java.lang.String arg0, android.graphics.Path arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawTextOnPath2890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawTextOnPath2890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawTextOnPath2891;
		public virtual void drawTextOnPath(char[] arg0, int arg1, int arg2, android.graphics.Path arg3, float arg4, float arg5, android.graphics.Paint arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawTextOnPath2891, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawTextOnPath2891, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPicture2892;
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPicture2892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPicture2892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPicture2893;
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.RectF arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPicture2893, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPicture2893, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawPicture2894;
		public virtual void drawPicture(android.graphics.Picture arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Canvas._drawPicture2894, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Canvas.staticClass, global::android.graphics.Canvas._drawPicture2894, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Canvas2895;
		public Canvas(android.graphics.Bitmap arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._Canvas2895, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Canvas2896;
		public Canvas(javax.microedition.khronos.opengles.GL arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._Canvas2896, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Canvas2897;
		public Canvas()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Canvas.staticClass, global::android.graphics.Canvas._Canvas2897, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Canvas.staticClass = @__class;
			global::android.graphics.Canvas._concat2811 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "concat", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Canvas._save2812 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "save", "()I");
			global::android.graphics.Canvas._save2813 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "save", "(I)I");
			global::android.graphics.Canvas._rotate2814 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "rotate", "(FFF)V");
			global::android.graphics.Canvas._rotate2815 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "rotate", "(F)V");
			global::android.graphics.Canvas._isOpaque2816 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "isOpaque", "()Z");
			global::android.graphics.Canvas._scale2817 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "scale", "(FFFF)V");
			global::android.graphics.Canvas._scale2818 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "scale", "(FF)V");
			global::android.graphics.Canvas._getDensity2819 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getDensity", "()I");
			global::android.graphics.Canvas._setDensity2820 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setDensity", "(I)V");
			global::android.graphics.Canvas._getWidth2821 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getWidth", "()I");
			global::android.graphics.Canvas._getHeight2822 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getHeight", "()I");
			global::android.graphics.Canvas._getGL2823 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;");
			global::android.graphics.Canvas._freeGlCaches2824 = @__env.GetStaticMethodID(global::android.graphics.Canvas.staticClass, "freeGlCaches", "()V");
			global::android.graphics.Canvas._setBitmap2825 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.Canvas._setViewport2826 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setViewport", "(II)V");
			global::android.graphics.Canvas._saveLayer2827 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "saveLayer", "(Landroid/graphics/RectF;Landroid/graphics/Paint;I)I");
			global::android.graphics.Canvas._saveLayer2828 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "saveLayer", "(FFFFLandroid/graphics/Paint;I)I");
			global::android.graphics.Canvas._saveLayerAlpha2829 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(FFFFII)I");
			global::android.graphics.Canvas._saveLayerAlpha2830 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(Landroid/graphics/RectF;II)I");
			global::android.graphics.Canvas._restore2831 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "restore", "()V");
			global::android.graphics.Canvas._getSaveCount2832 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getSaveCount", "()I");
			global::android.graphics.Canvas._restoreToCount2833 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "restoreToCount", "(I)V");
			global::android.graphics.Canvas._translate2834 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "translate", "(FF)V");
			global::android.graphics.Canvas._skew2835 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "skew", "(FF)V");
			global::android.graphics.Canvas._setMatrix2836 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Canvas._getMatrix2837 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getMatrix", "()Landroid/graphics/Matrix;");
			global::android.graphics.Canvas._getMatrix2838 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Canvas._clipRect2839 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRect2840 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.Canvas._clipRect2841 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Canvas._clipRect2842 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(FFFFLandroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRect2843 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(FFFF)Z");
			global::android.graphics.Canvas._clipRect2844 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(IIII)Z");
			global::android.graphics.Canvas._clipRect2845 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipPath2846 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;)Z");
			global::android.graphics.Canvas._clipPath2847 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRegion2848 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Canvas._clipRegion2849 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Canvas._getDrawFilter2850 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getDrawFilter", "()Landroid/graphics/DrawFilter;");
			global::android.graphics.Canvas._setDrawFilter2851 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setDrawFilter", "(Landroid/graphics/DrawFilter;)V");
			global::android.graphics.Canvas._quickReject2852 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/RectF;Landroid/graphics/Canvas$EdgeType;)Z");
			global::android.graphics.Canvas._quickReject2853 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/Path;Landroid/graphics/Canvas$EdgeType;)Z");
			global::android.graphics.Canvas._quickReject2854 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "quickReject", "(FFFFLandroid/graphics/Canvas$EdgeType;)Z");
			global::android.graphics.Canvas._getClipBounds2855 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getClipBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.Canvas._getClipBounds2856 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getClipBounds", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Canvas._drawRGB2857 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRGB", "(III)V");
			global::android.graphics.Canvas._drawARGB2858 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawARGB", "(IIII)V");
			global::android.graphics.Canvas._drawColor2859 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawColor", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.graphics.Canvas._drawColor2860 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawColor", "(I)V");
			global::android.graphics.Canvas._drawPaint2861 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPaint", "(Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPoints2862 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPoints", "([FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPoints2863 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPoints", "([FIILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPoint2864 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPoint", "(FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawLine2865 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawLine", "(FFFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawLines2866 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawLines", "([FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawLines2867 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawLines", "([FIILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRect2868 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRect2869 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRect", "(FFFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRect2870 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawOval2871 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawOval", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawCircle2872 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawCircle", "(FFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawArc2873 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawArc", "(Landroid/graphics/RectF;FFZLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawRoundRect2874 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPath2875 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPath", "(Landroid/graphics/Path;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap2876 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap2877 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap2878 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIFFIIZLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap2879 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIIIIIZLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap2880 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;Landroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmap2881 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawBitmapMesh2882 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmapMesh", "(Landroid/graphics/Bitmap;II[FI[IILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawVertices2883 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawVertices", "(Landroid/graphics/Canvas$VertexMode;I[FI[FI[II[SIILandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText2884 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/CharSequence;IIFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText2885 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText2886 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawText", "([CIIFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawText2887 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;IIFFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPosText2888 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPosText", "(Ljava/lang/String;[FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPosText2889 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPosText", "([CII[FLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawTextOnPath2890 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawTextOnPath", "(Ljava/lang/String;Landroid/graphics/Path;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawTextOnPath2891 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawTextOnPath", "([CIILandroid/graphics/Path;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Canvas._drawPicture2892 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/Rect;)V");
			global::android.graphics.Canvas._drawPicture2893 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/RectF;)V");
			global::android.graphics.Canvas._drawPicture2894 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;)V");
			global::android.graphics.Canvas._Canvas2895 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.Canvas._Canvas2896 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "<init>", "(Ljavax/microedition/khronos/opengles/GL;)V");
			global::android.graphics.Canvas._Canvas2897 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "<init>", "()V");
		}
	}
}
