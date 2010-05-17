namespace android.view.accessibility 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class AccessibilityEvent : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static AccessibilityEvent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.accessibility.AccessibilityEvent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.accessibility.AccessibilityEvent(@__env); 
			} 
		} 
		internal AccessibilityEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString8151; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString8151)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.accessibility.AccessibilityEvent.staticClass, _toString8151)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClassName8152; 
		public java.lang.CharSequence getClassName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getClassName8152)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.accessibility.AccessibilityEvent.staticClass, _getClassName8152)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName8153; 
		public java.lang.CharSequence getPackageName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getPackageName8153)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.accessibility.AccessibilityEvent.staticClass, _getPackageName8153)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText8154; 
		public java.util.List getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getText8154)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.accessibility.AccessibilityEvent.staticClass, _getText8154)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChecked8155; 
		public bool isChecked() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallBooleanMethod(this, _isChecked8155); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _isChecked8155); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChecked8156; 
		public void setChecked(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setChecked8156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setChecked8156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled8157; 
		public bool isEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallBooleanMethod(this, _isEnabled8157); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _isEnabled8157); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled8158; 
		public void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setEnabled8158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setEnabled8158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPassword8159; 
		public bool isPassword() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallBooleanMethod(this, _isPassword8159); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _isPassword8159); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPassword8160; 
		public void setPassword(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setPassword8160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setPassword8160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFullScreen8161; 
		public void setFullScreen(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setFullScreen8161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setFullScreen8161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFullScreen8162; 
		public bool isFullScreen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallBooleanMethod(this, _isFullScreen8162); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _isFullScreen8162); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventType8163; 
		public int getEventType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallIntMethod(this, _getEventType8163); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _getEventType8163); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventType8164; 
		public void setEventType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setEventType8164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setEventType8164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemCount8165; 
		public int getItemCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallIntMethod(this, _getItemCount8165); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _getItemCount8165); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setItemCount8166; 
		public void setItemCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setItemCount8166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setItemCount8166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentItemIndex8167; 
		public int getCurrentItemIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallIntMethod(this, _getCurrentItemIndex8167); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _getCurrentItemIndex8167); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentItemIndex8168; 
		public void setCurrentItemIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setCurrentItemIndex8168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setCurrentItemIndex8168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFromIndex8169; 
		public int getFromIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallIntMethod(this, _getFromIndex8169); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _getFromIndex8169); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFromIndex8170; 
		public void setFromIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setFromIndex8170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setFromIndex8170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddedCount8171; 
		public int getAddedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallIntMethod(this, _getAddedCount8171); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _getAddedCount8171); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAddedCount8172; 
		public void setAddedCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setAddedCount8172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setAddedCount8172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemovedCount8173; 
		public int getRemovedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallIntMethod(this, _getRemovedCount8173); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _getRemovedCount8173); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRemovedCount8174; 
		public void setRemovedCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setRemovedCount8174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setRemovedCount8174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventTime8175; 
		public long getEventTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallLongMethod(this, _getEventTime8175); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _getEventTime8175); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventTime8176; 
		public void setEventTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setEventTime8176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setEventTime8176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClassName8177; 
		public void setClassName(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setClassName8177, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setClassName8177, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPackageName8178; 
		public void setPackageName(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setPackageName8178, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setPackageName8178, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBeforeText8179; 
		public java.lang.CharSequence getBeforeText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getBeforeText8179)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.accessibility.AccessibilityEvent.staticClass, _getBeforeText8179)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBeforeText8180; 
		public void setBeforeText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setBeforeText8180, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setBeforeText8180, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentDescription8181; 
		public java.lang.CharSequence getContentDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getContentDescription8181)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.accessibility.AccessibilityEvent.staticClass, _getContentDescription8181)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentDescription8182; 
		public void setContentDescription(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setContentDescription8182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setContentDescription8182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableData8183; 
		public android.os.Parcelable getParcelableData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _getParcelableData8183)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.accessibility.AccessibilityEvent.staticClass, _getParcelableData8183)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setParcelableData8184; 
		public void setParcelableData(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _setParcelableData8184, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _setParcelableData8184, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain8185; 
		public static android.view.accessibility.AccessibilityEvent obtain() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.accessibility.AccessibilityEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.accessibility.AccessibilityEvent.staticClass, _obtain8185)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain8186; 
		public static android.view.accessibility.AccessibilityEvent obtain(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.accessibility.AccessibilityEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.accessibility.AccessibilityEvent.staticClass, _obtain8186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle8187; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _recycle8187); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _recycle8187); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initFromParcel8188; 
		public void initFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _initFromParcel8188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _initFromParcel8188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8189; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				@__env.CallVoidMethod(this, _writeToParcel8189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _writeToParcel8189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8190; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityEvent)) 
				return @__env.CallIntMethod(this, _describeContents8190); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.accessibility.AccessibilityEvent.staticClass, _describeContents8190); 
		} 
		public static int INVALID_POSITION
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static int MAX_TEXT_LENGTH
		{ 
			get 
			{ 
				return 500; 
			} 
		} 
		public static int TYPE_VIEW_CLICKED
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int TYPE_VIEW_LONG_CLICKED
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int TYPE_VIEW_SELECTED
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int TYPE_VIEW_FOCUSED
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int TYPE_VIEW_TEXT_CHANGED
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int TYPE_WINDOW_STATE_CHANGED
		{ 
			get 
			{ 
				return 32; 
			} 
		} 
		public static int TYPE_NOTIFICATION_STATE_CHANGED
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		public static int TYPES_ALL_MASK
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8191; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.accessibility.AccessibilityEvent.staticClass = @__class; 
			global::android.view.accessibility.AccessibilityEvent._toString8151 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.accessibility.AccessibilityEvent._getClassName8152 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getClassName", "()Ljava/lang/CharSequence;"); 
			global::android.view.accessibility.AccessibilityEvent._getPackageName8153 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getPackageName", "()Ljava/lang/CharSequence;"); 
			global::android.view.accessibility.AccessibilityEvent._getText8154 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getText", "()Ljava/util/List;"); 
			global::android.view.accessibility.AccessibilityEvent._isChecked8155 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isChecked", "()Z"); 
			global::android.view.accessibility.AccessibilityEvent._setChecked8156 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setChecked", "(Z)V"); 
			global::android.view.accessibility.AccessibilityEvent._isEnabled8157 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isEnabled", "()Z"); 
			global::android.view.accessibility.AccessibilityEvent._setEnabled8158 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEnabled", "(Z)V"); 
			global::android.view.accessibility.AccessibilityEvent._isPassword8159 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isPassword", "()Z"); 
			global::android.view.accessibility.AccessibilityEvent._setPassword8160 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPassword", "(Z)V"); 
			global::android.view.accessibility.AccessibilityEvent._setFullScreen8161 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFullScreen", "(Z)V"); 
			global::android.view.accessibility.AccessibilityEvent._isFullScreen8162 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isFullScreen", "()Z"); 
			global::android.view.accessibility.AccessibilityEvent._getEventType8163 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventType", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setEventType8164 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventType", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getItemCount8165 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getItemCount", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setItemCount8166 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setItemCount", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex8167 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getCurrentItemIndex", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex8168 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setCurrentItemIndex", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getFromIndex8169 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getFromIndex", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setFromIndex8170 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFromIndex", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getAddedCount8171 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getAddedCount", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setAddedCount8172 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setAddedCount", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getRemovedCount8173 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getRemovedCount", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setRemovedCount8174 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setRemovedCount", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getEventTime8175 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventTime", "()J"); 
			global::android.view.accessibility.AccessibilityEvent._setEventTime8176 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventTime", "(J)V"); 
			global::android.view.accessibility.AccessibilityEvent._setClassName8177 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setClassName", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.accessibility.AccessibilityEvent._setPackageName8178 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPackageName", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.accessibility.AccessibilityEvent._getBeforeText8179 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getBeforeText", "()Ljava/lang/CharSequence;"); 
			global::android.view.accessibility.AccessibilityEvent._setBeforeText8180 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setBeforeText", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.accessibility.AccessibilityEvent._getContentDescription8181 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;"); 
			global::android.view.accessibility.AccessibilityEvent._setContentDescription8182 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.accessibility.AccessibilityEvent._getParcelableData8183 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getParcelableData", "()Landroid/os/Parcelable;"); 
			global::android.view.accessibility.AccessibilityEvent._setParcelableData8184 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setParcelableData", "(Landroid/os/Parcelable;)V"); 
			global::android.view.accessibility.AccessibilityEvent._obtain8185 = @__env.GetStaticMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "()Landroid/view/accessibility/AccessibilityEvent;"); 
			global::android.view.accessibility.AccessibilityEvent._obtain8186 = @__env.GetStaticMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;"); 
			global::android.view.accessibility.AccessibilityEvent._recycle8187 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "recycle", "()V"); 
			global::android.view.accessibility.AccessibilityEvent._initFromParcel8188 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "initFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.view.accessibility.AccessibilityEvent._writeToParcel8189 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.accessibility.AccessibilityEvent._describeContents8190 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "describeContents", "()I"); 
		} 
	} 
} 
