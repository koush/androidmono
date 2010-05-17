namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DrawableContainer : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DrawableContainer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.DrawableContainer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.DrawableContainer(@__env); 
			} 
		} 
		protected DrawableContainer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public abstract class DrawableContainerState : android.graphics.drawable.Drawable.ConstantState
		{ 
			internal new static global::java.lang.Class staticClass; 
			static DrawableContainerState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			protected DrawableContainerState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3361; 
			public override int getChangingConfigurations() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallIntMethod(this, _getChangingConfigurations3361); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _getChangingConfigurations3361); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isStateful3362; 
			public virtual bool isStateful() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallBooleanMethod(this, _isStateful3362); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _isStateful3362); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getOpacity3363; 
			public virtual int getOpacity() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallIntMethod(this, _getOpacity3363); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _getOpacity3363); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getChildCount3364; 
			public virtual int getChildCount() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallIntMethod(this, _getChildCount3364); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _getChildCount3364); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addChild3365; 
			public virtual int addChild(android.graphics.drawable.Drawable arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallIntMethod(this, _addChild3365, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _addChild3365, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getChildren3366; 
			public virtual android.graphics.drawable.Drawable[] getChildren() 
			{ 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return null;//(@__env, @__env.CallObjectMethodPtr(this, _getChildren3366)); 
				else 
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _getChildren3366)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setVariablePadding3367; 
			public virtual void setVariablePadding(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					@__env.CallVoidMethod(this, _setVariablePadding3367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _setVariablePadding3367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getConstantPadding3368; 
			public virtual android.graphics.Rect getConstantPadding() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, _getConstantPadding3368)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _getConstantPadding3368)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setConstantSize3369; 
			public virtual void setConstantSize(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					@__env.CallVoidMethod(this, _setConstantSize3369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _setConstantSize3369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isConstantSize3370; 
			public virtual bool isConstantSize() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallBooleanMethod(this, _isConstantSize3370); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _isConstantSize3370); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getConstantWidth3371; 
			public virtual int getConstantWidth() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallIntMethod(this, _getConstantWidth3371); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _getConstantWidth3371); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getConstantHeight3372; 
			public virtual int getConstantHeight() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallIntMethod(this, _getConstantHeight3372); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _getConstantHeight3372); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getConstantMinimumWidth3373; 
			public virtual int getConstantMinimumWidth() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallIntMethod(this, _getConstantMinimumWidth3373); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _getConstantMinimumWidth3373); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getConstantMinimumHeight3374; 
			public virtual int getConstantMinimumHeight() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallIntMethod(this, _getConstantMinimumHeight3374); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _getConstantMinimumHeight3374); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _growArray3375; 
			public virtual void growArray(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					@__env.CallVoidMethod(this, _growArray3375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _growArray3375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _canConstantState3376; 
			public virtual bool canConstantState() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.DrawableContainer.DrawableContainerState)) 
					return @__env.CallBooleanMethod(this, _canConstantState3376); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, _canConstantState3376); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass = @__class; 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3361 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChangingConfigurations", "()I"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3362 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isStateful", "()Z"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3363 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getOpacity", "()I"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3364 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildCount", "()I"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3365 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "addChild", "(Landroid/graphics/drawable/Drawable;)I"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3366 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildren", "()[Landroid/graphics/drawable/Drawable;"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3367 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setVariablePadding", "(Z)V"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3368 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantPadding", "()Landroid/graphics/Rect;"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3369 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setConstantSize", "(Z)V"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3370 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isConstantSize", "()Z"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3371 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantWidth", "()I"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3372 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantHeight", "()I"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3373 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumWidth", "()I"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3374 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumHeight", "()I"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3375 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "growArray", "(II)V"); 
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3376 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "canConstantState", "()Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3377; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				@__env.CallVoidMethod(this, _draw3377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _draw3377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3378; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3378); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _getChangingConfigurations3378); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3379; 
		public override void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				@__env.CallVoidMethod(this, _setDither3379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _setDither3379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3380; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				@__env.CallVoidMethod(this, _setAlpha3380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _setAlpha3380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3381; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				@__env.CallVoidMethod(this, _setColorFilter3381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _setColorFilter3381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3382; 
		public override bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallBooleanMethod(this, _isStateful3382); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _isStateful3382); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrent3383; 
		public override android.graphics.drawable.Drawable getCurrent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getCurrent3383)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.DrawableContainer.staticClass, _getCurrent3383)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3384; 
		public override bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallBooleanMethod(this, _setVisible3384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _setVisible3384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3385; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallIntMethod(this, _getOpacity3385); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _getOpacity3385); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3386; 
		protected override bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallBooleanMethod(this, _onStateChange3386, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _onStateChange3386, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3387; 
		protected override bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _onLevelChange3387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3388; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				@__env.CallVoidMethod(this, _onBoundsChange3388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _onBoundsChange3388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3389; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3389); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _getIntrinsicWidth3389); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3390; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3390); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _getIntrinsicHeight3390); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumWidth3391; 
		public override int getMinimumWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallIntMethod(this, _getMinimumWidth3391); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _getMinimumWidth3391); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumHeight3392; 
		public override int getMinimumHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallIntMethod(this, _getMinimumHeight3392); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _getMinimumHeight3392); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3393; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallBooleanMethod(this, _getPadding3393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _getPadding3393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3394; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3394)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.DrawableContainer.staticClass, _mutate3394)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3395; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3395)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.DrawableContainer.staticClass, _getConstantState3395)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3396; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				@__env.CallVoidMethod(this, _invalidateDrawable3396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _invalidateDrawable3396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3397; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				@__env.CallVoidMethod(this, _scheduleDrawable3397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _scheduleDrawable3397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3398; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				@__env.CallVoidMethod(this, _unscheduleDrawable3398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _unscheduleDrawable3398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _selectDrawable3399; 
		public virtual bool selectDrawable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				return @__env.CallBooleanMethod(this, _selectDrawable3399, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _selectDrawable3399, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setConstantState3400; 
		protected virtual void setConstantState(android.graphics.drawable.DrawableContainer.DrawableContainerState arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.DrawableContainer)) 
				@__env.CallVoidMethod(this, _setConstantState3400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.DrawableContainer.staticClass, _setConstantState3400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DrawableContainer3401; 
		public DrawableContainer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.DrawableContainer.staticClass, _DrawableContainer3401, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.DrawableContainer.staticClass = @__class; 
			global::android.graphics.drawable.DrawableContainer._draw3377 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3378 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.DrawableContainer._setDither3379 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.DrawableContainer._setAlpha3380 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.DrawableContainer._setColorFilter3381 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.DrawableContainer._isStateful3382 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.DrawableContainer._getCurrent3383 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.DrawableContainer._setVisible3384 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.DrawableContainer._getOpacity3385 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.DrawableContainer._onStateChange3386 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.DrawableContainer._onLevelChange3387 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.DrawableContainer._onBoundsChange3388 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth3389 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight3390 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.DrawableContainer._getMinimumWidth3391 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumWidth", "()I"); 
			global::android.graphics.drawable.DrawableContainer._getMinimumHeight3392 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumHeight", "()I"); 
			global::android.graphics.drawable.DrawableContainer._getPadding3393 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.DrawableContainer._mutate3394 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.DrawableContainer._getConstantState3395 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.DrawableContainer._invalidateDrawable3396 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.DrawableContainer._scheduleDrawable3397 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.DrawableContainer._unscheduleDrawable3398 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.DrawableContainer._selectDrawable3399 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "selectDrawable", "(I)Z"); 
			global::android.graphics.drawable.DrawableContainer._setConstantState3400 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "setConstantState", "(Landroid/graphics/drawable/DrawableContainer$DrawableContainerState;)V"); 
			global::android.graphics.drawable.DrawableContainer._DrawableContainer3401 = @__env.GetMethodID(global::android.graphics.drawable.DrawableContainer.staticClass, "<init>", "()V"); 
		} 
	} 
} 
