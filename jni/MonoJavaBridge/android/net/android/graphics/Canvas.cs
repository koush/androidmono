namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Canvas : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Canvas() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Canvas), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Canvas.EdgeType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2602; 
			public static android.graphics.Canvas.EdgeType valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas.EdgeType>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Canvas.EdgeType.staticClass, _valueOf2602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2603; 
			public static android.graphics.Canvas.EdgeType[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Canvas.EdgeType.staticClass, _values2603)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _AA2604; 
			public static android.graphics.Canvas.EdgeType AA
			{ 
				get 
				{ 
					return default(android.graphics.Canvas.EdgeType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BW2605; 
			public static android.graphics.Canvas.EdgeType BW
			{ 
				get 
				{ 
					return default(android.graphics.Canvas.EdgeType); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Canvas.EdgeType.staticClass = @__class; 
				global::android.graphics.Canvas.EdgeType._valueOf2602 = @__env.GetStaticMethodID(global::android.graphics.Canvas.EdgeType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$EdgeType;"); 
				global::android.graphics.Canvas.EdgeType._values2603 = @__env.GetStaticMethodID(global::android.graphics.Canvas.EdgeType.staticClass, "values", "()[Landroid/graphics/Canvas/EdgeType;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class VertexMode : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static VertexMode() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Canvas.VertexMode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2606; 
			public static android.graphics.Canvas.VertexMode valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas.VertexMode>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Canvas.VertexMode.staticClass, _valueOf2606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2607; 
			public static android.graphics.Canvas.VertexMode[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Canvas.VertexMode.staticClass, _values2607)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TRIANGLES2608; 
			public static android.graphics.Canvas.VertexMode TRIANGLES
			{ 
				get 
				{ 
					return default(android.graphics.Canvas.VertexMode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TRIANGLE_FAN2609; 
			public static android.graphics.Canvas.VertexMode TRIANGLE_FAN
			{ 
				get 
				{ 
					return default(android.graphics.Canvas.VertexMode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TRIANGLE_STRIP2610; 
			public static android.graphics.Canvas.VertexMode TRIANGLE_STRIP
			{ 
				get 
				{ 
					return default(android.graphics.Canvas.VertexMode); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Canvas.VertexMode.staticClass = @__class; 
				global::android.graphics.Canvas.VertexMode._valueOf2606 = @__env.GetStaticMethodID(global::android.graphics.Canvas.VertexMode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$VertexMode;"); 
				global::android.graphics.Canvas.VertexMode._values2607 = @__env.GetStaticMethodID(global::android.graphics.Canvas.VertexMode.staticClass, "values", "()[Landroid/graphics/Canvas/VertexMode;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _concat2611; 
		public virtual void concat(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _concat2611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _concat2611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _save2612; 
		public virtual int save() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _save2612); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _save2612); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _save2613; 
		public virtual int save(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _save2613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _save2613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rotate2614; 
		public virtual void rotate(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _rotate2614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _rotate2614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rotate2615; 
		public virtual void rotate(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _rotate2615, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _rotate2615, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque2616; 
		public virtual bool isOpaque() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _isOpaque2616); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _isOpaque2616); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scale2617; 
		public virtual void scale(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _scale2617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _scale2617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scale2618; 
		public virtual void scale(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _scale2618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _scale2618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDensity2619; 
		public virtual int getDensity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _getDensity2619); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _getDensity2619); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDensity2620; 
		public virtual void setDensity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _setDensity2620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _setDensity2620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth2621; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _getWidth2621); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _getWidth2621); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight2622; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _getHeight2622); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _getHeight2622); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGL2623; 
		public virtual javax.microedition.khronos.opengles.GL getGL() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.microedition.khronos.opengles.GL>(@__env, @__env.CallObjectMethodPtr(this, _getGL2623)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.microedition.khronos.opengles.GL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Canvas.staticClass, _getGL2623)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _freeGlCaches2624; 
		public static void freeGlCaches() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.graphics.Canvas.staticClass, _freeGlCaches2624); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBitmap2625; 
		public virtual void setBitmap(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _setBitmap2625, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _setBitmap2625, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewport2626; 
		public virtual void setViewport(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _setViewport2626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _setViewport2626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveLayer2627; 
		public virtual int saveLayer(android.graphics.RectF arg0, android.graphics.Paint arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _saveLayer2627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _saveLayer2627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveLayer2628; 
		public virtual int saveLayer(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _saveLayer2628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _saveLayer2628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveLayerAlpha2629; 
		public virtual int saveLayerAlpha(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _saveLayerAlpha2629, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _saveLayerAlpha2629, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveLayerAlpha2630; 
		public virtual int saveLayerAlpha(android.graphics.RectF arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _saveLayerAlpha2630, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _saveLayerAlpha2630, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restore2631; 
		public virtual void restore() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _restore2631); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _restore2631); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSaveCount2632; 
		public virtual int getSaveCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallIntMethod(this, _getSaveCount2632); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Canvas.staticClass, _getSaveCount2632); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restoreToCount2633; 
		public virtual void restoreToCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _restoreToCount2633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _restoreToCount2633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _translate2634; 
		public virtual void translate(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _translate2634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _translate2634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _skew2635; 
		public virtual void skew(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _skew2635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _skew2635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMatrix2636; 
		public virtual void setMatrix(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _setMatrix2636, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _setMatrix2636, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix2637; 
		public virtual android.graphics.Matrix getMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallObjectMethodPtr(this, _getMatrix2637)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Canvas.staticClass, _getMatrix2637)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix2638; 
		public virtual void getMatrix(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _getMatrix2638, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _getMatrix2638, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2639; 
		public virtual bool clipRect(android.graphics.Rect arg0, android.graphics.Region.Op arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipRect2639, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipRect2639, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2640; 
		public virtual bool clipRect(android.graphics.RectF arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipRect2640, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipRect2640, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2641; 
		public virtual bool clipRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipRect2641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipRect2641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2642; 
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Region.Op arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipRect2642, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipRect2642, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2643; 
		public virtual bool clipRect(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipRect2643, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipRect2643, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2644; 
		public virtual bool clipRect(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipRect2644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipRect2644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipRect2645; 
		public virtual bool clipRect(android.graphics.RectF arg0, android.graphics.Region.Op arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipRect2645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipRect2645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipPath2646; 
		public virtual bool clipPath(android.graphics.Path arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipPath2646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipPath2646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipPath2647; 
		public virtual bool clipPath(android.graphics.Path arg0, android.graphics.Region.Op arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipPath2647, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipPath2647, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipRegion2648; 
		public virtual bool clipRegion(android.graphics.Region arg0, android.graphics.Region.Op arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipRegion2648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipRegion2648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clipRegion2649; 
		public virtual bool clipRegion(android.graphics.Region arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _clipRegion2649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _clipRegion2649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawFilter2650; 
		public virtual android.graphics.DrawFilter getDrawFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.DrawFilter>(@__env, @__env.CallObjectMethodPtr(this, _getDrawFilter2650)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.DrawFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Canvas.staticClass, _getDrawFilter2650)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDrawFilter2651; 
		public virtual void setDrawFilter(android.graphics.DrawFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _setDrawFilter2651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _setDrawFilter2651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quickReject2652; 
		public virtual bool quickReject(android.graphics.RectF arg0, android.graphics.Canvas.EdgeType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _quickReject2652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _quickReject2652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quickReject2653; 
		public virtual bool quickReject(android.graphics.Path arg0, android.graphics.Canvas.EdgeType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _quickReject2653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _quickReject2653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quickReject2654; 
		public virtual bool quickReject(float arg0, float arg1, float arg2, float arg3, android.graphics.Canvas.EdgeType arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _quickReject2654, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _quickReject2654, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClipBounds2655; 
		public virtual android.graphics.Rect getClipBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, _getClipBounds2655)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Canvas.staticClass, _getClipBounds2655)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClipBounds2656; 
		public virtual bool getClipBounds(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				return @__env.CallBooleanMethod(this, _getClipBounds2656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Canvas.staticClass, _getClipBounds2656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawRGB2657; 
		public virtual void drawRGB(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawRGB2657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawRGB2657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawARGB2658; 
		public virtual void drawARGB(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawARGB2658, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawARGB2658, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawColor2659; 
		public virtual void drawColor(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawColor2659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawColor2659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawColor2660; 
		public virtual void drawColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawColor2660, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawColor2660, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPaint2661; 
		public virtual void drawPaint(android.graphics.Paint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPaint2661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPaint2661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPoints2662; 
		public virtual void drawPoints(float[] arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPoints2662, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPoints2662, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPoints2663; 
		public virtual void drawPoints(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPoints2663, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPoints2663, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPoint2664; 
		public virtual void drawPoint(float arg0, float arg1, android.graphics.Paint arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPoint2664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPoint2664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawLine2665; 
		public virtual void drawLine(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawLine2665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawLine2665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawLines2666; 
		public virtual void drawLines(float[] arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawLines2666, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawLines2666, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawLines2667; 
		public virtual void drawLines(float[] arg0, int arg1, int arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawLines2667, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawLines2667, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawRect2668; 
		public virtual void drawRect(android.graphics.Rect arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawRect2668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawRect2668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawRect2669; 
		public virtual void drawRect(float arg0, float arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawRect2669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawRect2669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawRect2670; 
		public virtual void drawRect(android.graphics.RectF arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawRect2670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawRect2670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawOval2671; 
		public virtual void drawOval(android.graphics.RectF arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawOval2671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawOval2671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawCircle2672; 
		public virtual void drawCircle(float arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawCircle2672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawCircle2672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawArc2673; 
		public virtual void drawArc(android.graphics.RectF arg0, float arg1, float arg2, bool arg3, android.graphics.Paint arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawArc2673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawArc2673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawRoundRect2674; 
		public virtual void drawRoundRect(android.graphics.RectF arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawRoundRect2674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawRoundRect2674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPath2675; 
		public virtual void drawPath(android.graphics.Path arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPath2675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPath2675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2676; 
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.RectF arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawBitmap2676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawBitmap2676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2677; 
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Rect arg1, android.graphics.Rect arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawBitmap2677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawBitmap2677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2678; 
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, float arg3, float arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawBitmap2678, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawBitmap2678, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2679; 
		public virtual void drawBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, android.graphics.Paint arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawBitmap2679, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawBitmap2679, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2680; 
		public virtual void drawBitmap(android.graphics.Bitmap arg0, android.graphics.Matrix arg1, android.graphics.Paint arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawBitmap2680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawBitmap2680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmap2681; 
		public virtual void drawBitmap(android.graphics.Bitmap arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawBitmap2681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawBitmap2681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawBitmapMesh2682; 
		public virtual void drawBitmapMesh(android.graphics.Bitmap arg0, int arg1, int arg2, float[] arg3, int arg4, int[] arg5, int arg6, android.graphics.Paint arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawBitmapMesh2682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawBitmapMesh2682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawVertices2683; 
		public virtual void drawVertices(android.graphics.Canvas.VertexMode arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5, int[] arg6, int arg7, short[] arg8, int arg9, int arg10, android.graphics.Paint arg11) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawVertices2683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawVertices2683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawText2684; 
		public virtual void drawText(java.lang.CharSequence arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawText2684, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawText2684, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawText2685; 
		public virtual void drawText(java.lang.String arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawText2685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawText2685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawText2686; 
		public virtual void drawText(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawText2686, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawText2686, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawText2687; 
		public virtual void drawText(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Paint arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawText2687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawText2687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPosText2688; 
		public virtual void drawPosText(java.lang.String arg0, float[] arg1, android.graphics.Paint arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPosText2688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPosText2688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPosText2689; 
		public virtual void drawPosText(char[] arg0, int arg1, int arg2, float[] arg3, android.graphics.Paint arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPosText2689, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPosText2689, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawTextOnPath2690; 
		public virtual void drawTextOnPath(java.lang.String arg0, android.graphics.Path arg1, float arg2, float arg3, android.graphics.Paint arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawTextOnPath2690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawTextOnPath2690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawTextOnPath2691; 
		public virtual void drawTextOnPath(char[] arg0, int arg1, int arg2, android.graphics.Path arg3, float arg4, float arg5, android.graphics.Paint arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawTextOnPath2691, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawTextOnPath2691, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPicture2692; 
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPicture2692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPicture2692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPicture2693; 
		public virtual void drawPicture(android.graphics.Picture arg0, android.graphics.RectF arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPicture2693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPicture2693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawPicture2694; 
		public virtual void drawPicture(android.graphics.Picture arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Canvas)) 
				@__env.CallVoidMethod(this, _drawPicture2694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Canvas.staticClass, _drawPicture2694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Canvas2695; 
		public Canvas(android.graphics.Bitmap arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Canvas.staticClass, _Canvas2695, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Canvas2696; 
		public Canvas(javax.microedition.khronos.opengles.GL arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Canvas.staticClass, _Canvas2696, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Canvas2697; 
		public Canvas()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Canvas.staticClass, _Canvas2697, this); 
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
			global::android.graphics.Canvas._concat2611 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "concat", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Canvas._save2612 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "save", "()I"); 
			global::android.graphics.Canvas._save2613 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "save", "(I)I"); 
			global::android.graphics.Canvas._rotate2614 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "rotate", "(FFF)V"); 
			global::android.graphics.Canvas._rotate2615 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "rotate", "(F)V"); 
			global::android.graphics.Canvas._isOpaque2616 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "isOpaque", "()Z"); 
			global::android.graphics.Canvas._scale2617 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "scale", "(FFFF)V"); 
			global::android.graphics.Canvas._scale2618 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "scale", "(FF)V"); 
			global::android.graphics.Canvas._getDensity2619 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getDensity", "()I"); 
			global::android.graphics.Canvas._setDensity2620 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setDensity", "(I)V"); 
			global::android.graphics.Canvas._getWidth2621 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getWidth", "()I"); 
			global::android.graphics.Canvas._getHeight2622 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getHeight", "()I"); 
			global::android.graphics.Canvas._getGL2623 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;"); 
			global::android.graphics.Canvas._freeGlCaches2624 = @__env.GetStaticMethodID(global::android.graphics.Canvas.staticClass, "freeGlCaches", "()V"); 
			global::android.graphics.Canvas._setBitmap2625 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V"); 
			global::android.graphics.Canvas._setViewport2626 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setViewport", "(II)V"); 
			global::android.graphics.Canvas._saveLayer2627 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "saveLayer", "(Landroid/graphics/RectF;Landroid/graphics/Paint;I)I"); 
			global::android.graphics.Canvas._saveLayer2628 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "saveLayer", "(FFFFLandroid/graphics/Paint;I)I"); 
			global::android.graphics.Canvas._saveLayerAlpha2629 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(FFFFII)I"); 
			global::android.graphics.Canvas._saveLayerAlpha2630 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "saveLayerAlpha", "(Landroid/graphics/RectF;II)I"); 
			global::android.graphics.Canvas._restore2631 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "restore", "()V"); 
			global::android.graphics.Canvas._getSaveCount2632 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getSaveCount", "()I"); 
			global::android.graphics.Canvas._restoreToCount2633 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "restoreToCount", "(I)V"); 
			global::android.graphics.Canvas._translate2634 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "translate", "(FF)V"); 
			global::android.graphics.Canvas._skew2635 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "skew", "(FF)V"); 
			global::android.graphics.Canvas._setMatrix2636 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setMatrix", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Canvas._getMatrix2637 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getMatrix", "()Landroid/graphics/Matrix;"); 
			global::android.graphics.Canvas._getMatrix2638 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getMatrix", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Canvas._clipRect2639 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Canvas._clipRect2640 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;)Z"); 
			global::android.graphics.Canvas._clipRect2641 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Canvas._clipRect2642 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(FFFFLandroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Canvas._clipRect2643 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(FFFF)Z"); 
			global::android.graphics.Canvas._clipRect2644 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(IIII)Z"); 
			global::android.graphics.Canvas._clipRect2645 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRect", "(Landroid/graphics/RectF;Landroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Canvas._clipPath2646 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;)Z"); 
			global::android.graphics.Canvas._clipPath2647 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipPath", "(Landroid/graphics/Path;Landroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Canvas._clipRegion2648 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z"); 
			global::android.graphics.Canvas._clipRegion2649 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "clipRegion", "(Landroid/graphics/Region;)Z"); 
			global::android.graphics.Canvas._getDrawFilter2650 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getDrawFilter", "()Landroid/graphics/DrawFilter;"); 
			global::android.graphics.Canvas._setDrawFilter2651 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "setDrawFilter", "(Landroid/graphics/DrawFilter;)V"); 
			global::android.graphics.Canvas._quickReject2652 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/RectF;Landroid/graphics/Canvas$EdgeType;)Z"); 
			global::android.graphics.Canvas._quickReject2653 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "quickReject", "(Landroid/graphics/Path;Landroid/graphics/Canvas$EdgeType;)Z"); 
			global::android.graphics.Canvas._quickReject2654 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "quickReject", "(FFFFLandroid/graphics/Canvas$EdgeType;)Z"); 
			global::android.graphics.Canvas._getClipBounds2655 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getClipBounds", "()Landroid/graphics/Rect;"); 
			global::android.graphics.Canvas._getClipBounds2656 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "getClipBounds", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.Canvas._drawRGB2657 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRGB", "(III)V"); 
			global::android.graphics.Canvas._drawARGB2658 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawARGB", "(IIII)V"); 
			global::android.graphics.Canvas._drawColor2659 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawColor", "(ILandroid/graphics/PorterDuff$Mode;)V"); 
			global::android.graphics.Canvas._drawColor2660 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawColor", "(I)V"); 
			global::android.graphics.Canvas._drawPaint2661 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPaint", "(Landroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawPoints2662 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPoints", "([FLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawPoints2663 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPoints", "([FIILandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawPoint2664 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPoint", "(FFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawLine2665 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawLine", "(FFFFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawLines2666 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawLines", "([FLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawLines2667 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawLines", "([FIILandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawRect2668 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/Rect;Landroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawRect2669 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRect", "(FFFFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawRect2670 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRect", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawOval2671 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawOval", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawCircle2672 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawCircle", "(FFFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawArc2673 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawArc", "(Landroid/graphics/RectF;FFZLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawRoundRect2674 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawPath2675 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPath", "(Landroid/graphics/Path;Landroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawBitmap2676 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawBitmap2677 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawBitmap2678 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIFFIIZLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawBitmap2679 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "([IIIIIIIZLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawBitmap2680 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;Landroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawBitmap2681 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmap", "(Landroid/graphics/Bitmap;FFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawBitmapMesh2682 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawBitmapMesh", "(Landroid/graphics/Bitmap;II[FI[IILandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawVertices2683 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawVertices", "(Landroid/graphics/Canvas$VertexMode;I[FI[FI[II[SIILandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawText2684 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/CharSequence;IIFFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawText2685 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;FFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawText2686 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawText", "([CIIFFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawText2687 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawText", "(Ljava/lang/String;IIFFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawPosText2688 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPosText", "(Ljava/lang/String;[FLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawPosText2689 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPosText", "([CII[FLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawTextOnPath2690 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawTextOnPath", "(Ljava/lang/String;Landroid/graphics/Path;FFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawTextOnPath2691 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawTextOnPath", "([CIILandroid/graphics/Path;FFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Canvas._drawPicture2692 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/Rect;)V"); 
			global::android.graphics.Canvas._drawPicture2693 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/RectF;)V"); 
			global::android.graphics.Canvas._drawPicture2694 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "drawPicture", "(Landroid/graphics/Picture;)V"); 
			global::android.graphics.Canvas._Canvas2695 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V"); 
			global::android.graphics.Canvas._Canvas2696 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "<init>", "(Ljavax/microedition/khronos/opengles/GL;)V"); 
			global::android.graphics.Canvas._Canvas2697 = @__env.GetMethodID(global::android.graphics.Canvas.staticClass, "<init>", "()V"); 
		} 
	} 
} 
