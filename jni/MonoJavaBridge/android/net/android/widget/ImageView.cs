namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ImageView : android.view.View
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ImageView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ImageView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ImageView(@__env); 
			} 
		} 
		protected ImageView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class ScaleType : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static ScaleType() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ImageView.ScaleType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.ImageView.ScaleType(@__env); 
				} 
			} 
			internal ScaleType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf9612; 
			public static android.widget.ImageView.ScaleType valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ImageView.ScaleType>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.ImageView.ScaleType.staticClass, _valueOf9612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values9613; 
			public static android.widget.ImageView.ScaleType[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.widget.ImageView.ScaleType.staticClass, _values9613)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CENTER9614; 
			public static android.widget.ImageView.ScaleType CENTER
			{ 
				get 
				{ 
					return default(android.widget.ImageView.ScaleType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CENTER_CROP9615; 
			public static android.widget.ImageView.ScaleType CENTER_CROP
			{ 
				get 
				{ 
					return default(android.widget.ImageView.ScaleType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CENTER_INSIDE9616; 
			public static android.widget.ImageView.ScaleType CENTER_INSIDE
			{ 
				get 
				{ 
					return default(android.widget.ImageView.ScaleType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FIT_CENTER9617; 
			public static android.widget.ImageView.ScaleType FIT_CENTER
			{ 
				get 
				{ 
					return default(android.widget.ImageView.ScaleType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FIT_END9618; 
			public static android.widget.ImageView.ScaleType FIT_END
			{ 
				get 
				{ 
					return default(android.widget.ImageView.ScaleType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FIT_START9619; 
			public static android.widget.ImageView.ScaleType FIT_START
			{ 
				get 
				{ 
					return default(android.widget.ImageView.ScaleType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FIT_XY9620; 
			public static android.widget.ImageView.ScaleType FIT_XY
			{ 
				get 
				{ 
					return default(android.widget.ImageView.ScaleType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MATRIX9621; 
			public static android.widget.ImageView.ScaleType MATRIX
			{ 
				get 
				{ 
					return default(android.widget.ImageView.ScaleType); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.ImageView.ScaleType.staticClass = @__class; 
				global::android.widget.ImageView.ScaleType._valueOf9612 = @__env.GetStaticMethodID(global::android.widget.ImageView.ScaleType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;"); 
				global::android.widget.ImageView.ScaleType._values9613 = @__env.GetStaticMethodID(global::android.widget.ImageView.ScaleType.staticClass, "values", "()[Landroid/widget/ImageView/ScaleType;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable9622; 
		public virtual android.graphics.drawable.Drawable getDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable9622)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ImageView.staticClass, _getDrawable9622)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha9623; 
		public virtual void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setAlpha9623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setAlpha9623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter9624; 
		public virtual void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setColorFilter9624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setColorFilter9624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter9625; 
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setColorFilter9625, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setColorFilter9625, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearColorFilter9626; 
		public virtual void clearColorFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _clearColorFilter9626); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _clearColorFilter9626); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw9627; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _onDraw9627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _onDraw9627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable9628; 
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _invalidateDrawable9628, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _invalidateDrawable9628, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable9629; 
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				return @__env.CallBooleanMethod(this, _verifyDrawable9629, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ImageView.staticClass, _verifyDrawable9629, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9630; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _drawableStateChanged9630); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _drawableStateChanged9630); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState9631; 
		public virtual new int[] onCreateDrawableState(int arg0) 
		{ 
			if (GetType() == typeof(android.widget.ImageView)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _onCreateDrawableState9631, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ImageView.staticClass, _onCreateDrawableState9631, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelected9632; 
		public override void setSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setSelected9632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setSelected9632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline9633; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				return @__env.CallIntMethod(this, _getBaseline9633); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ImageView.staticClass, _getBaseline9633); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9634; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _onMeasure9634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _onMeasure9634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetAlpha9635; 
		protected override bool onSetAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				return @__env.CallBooleanMethod(this, _onSetAlpha9635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ImageView.staticClass, _onSetAlpha9635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxHeight9636; 
		public virtual void setMaxHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setMaxHeight9636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setMaxHeight9636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxWidth9637; 
		public virtual void setMaxWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setMaxWidth9637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setMaxWidth9637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFrame9638; 
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				return @__env.CallBooleanMethod(this, _setFrame9638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ImageView.staticClass, _setFrame9638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdjustViewBounds9639; 
		public virtual void setAdjustViewBounds(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setAdjustViewBounds9639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setAdjustViewBounds9639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageResource9640; 
		public virtual void setImageResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setImageResource9640, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setImageResource9640, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageURI9641; 
		public virtual void setImageURI(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setImageURI9641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setImageURI9641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageDrawable9642; 
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setImageDrawable9642, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setImageDrawable9642, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageBitmap9643; 
		public virtual void setImageBitmap(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setImageBitmap9643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setImageBitmap9643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageState9644; 
		public virtual void setImageState(int[] arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setImageState9644, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setImageState9644, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageLevel9645; 
		public virtual void setImageLevel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setImageLevel9645, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setImageLevel9645, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScaleType9646; 
		public virtual void setScaleType(android.widget.ImageView.ScaleType arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setScaleType9646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setScaleType9646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaleType9647; 
		public virtual android.widget.ImageView.ScaleType getScaleType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ImageView.ScaleType>(@__env, @__env.CallObjectMethodPtr(this, _getScaleType9647)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ImageView.ScaleType>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ImageView.staticClass, _getScaleType9647)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImageMatrix9648; 
		public virtual android.graphics.Matrix getImageMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallObjectMethodPtr(this, _getImageMatrix9648)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ImageView.staticClass, _getImageMatrix9648)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageMatrix9649; 
		public virtual void setImageMatrix(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageView)) 
				@__env.CallVoidMethod(this, _setImageMatrix9649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageView.staticClass, _setImageMatrix9649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageView9650; 
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ImageView.staticClass, _ImageView9650, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageView9651; 
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ImageView.staticClass, _ImageView9651, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageView9652; 
		public ImageView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ImageView.staticClass, _ImageView9652, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ImageView.staticClass = @__class; 
			global::android.widget.ImageView._getDrawable9622 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.ImageView._setAlpha9623 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setAlpha", "(I)V"); 
			global::android.widget.ImageView._setColorFilter9624 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.widget.ImageView._setColorFilter9625 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V"); 
			global::android.widget.ImageView._clearColorFilter9626 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "clearColorFilter", "()V"); 
			global::android.widget.ImageView._onDraw9627 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.ImageView._invalidateDrawable9628 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ImageView._verifyDrawable9629 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.widget.ImageView._drawableStateChanged9630 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.ImageView._onCreateDrawableState9631 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "onCreateDrawableState", "(I)[I"); 
			global::android.widget.ImageView._setSelected9632 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setSelected", "(Z)V"); 
			global::android.widget.ImageView._getBaseline9633 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "getBaseline", "()I"); 
			global::android.widget.ImageView._onMeasure9634 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.ImageView._onSetAlpha9635 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "onSetAlpha", "(I)Z"); 
			global::android.widget.ImageView._setMaxHeight9636 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setMaxHeight", "(I)V"); 
			global::android.widget.ImageView._setMaxWidth9637 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setMaxWidth", "(I)V"); 
			global::android.widget.ImageView._setFrame9638 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setFrame", "(IIII)Z"); 
			global::android.widget.ImageView._setAdjustViewBounds9639 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setAdjustViewBounds", "(Z)V"); 
			global::android.widget.ImageView._setImageResource9640 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageResource", "(I)V"); 
			global::android.widget.ImageView._setImageURI9641 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageURI", "(Landroid/net/Uri;)V"); 
			global::android.widget.ImageView._setImageDrawable9642 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ImageView._setImageBitmap9643 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageBitmap", "(Landroid/graphics/Bitmap;)V"); 
			global::android.widget.ImageView._setImageState9644 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageState", "([IZ)V"); 
			global::android.widget.ImageView._setImageLevel9645 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageLevel", "(I)V"); 
			global::android.widget.ImageView._setScaleType9646 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setScaleType", "(Landroid/widget/ImageView$ScaleType;)V"); 
			global::android.widget.ImageView._getScaleType9647 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "getScaleType", "()Landroid/widget/ImageView$ScaleType;"); 
			global::android.widget.ImageView._getImageMatrix9648 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "getImageMatrix", "()Landroid/graphics/Matrix;"); 
			global::android.widget.ImageView._setImageMatrix9649 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageMatrix", "(Landroid/graphics/Matrix;)V"); 
			global::android.widget.ImageView._ImageView9650 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ImageView._ImageView9651 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.ImageView._ImageView9652 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
