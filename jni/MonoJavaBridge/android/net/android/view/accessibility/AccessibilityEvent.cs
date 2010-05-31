namespace android.view.accessibility 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class AccessibilityEvent : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static AccessibilityEvent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.accessibility.AccessibilityEvent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString8788; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._toString8788)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._toString8788)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClassName8789; 
		public global::java.lang.CharSequence getClassName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getClassName8789)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getClassName8789)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName8790; 
		public global::java.lang.CharSequence getPackageName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getPackageName8790)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getPackageName8790)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText8791; 
		public global::java.util.List getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getText8791)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getText8791)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChecked8792; 
		public bool isChecked() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent._isChecked8792); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isChecked8792); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChecked8793; 
		public void setChecked(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setChecked8793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setChecked8793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled8794; 
		public bool isEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent._isEnabled8794); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isEnabled8794); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled8795; 
		public void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setEnabled8795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEnabled8795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPassword8796; 
		public bool isPassword() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent._isPassword8796); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isPassword8796); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPassword8797; 
		public void setPassword(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setPassword8797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPassword8797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFullScreen8798; 
		public void setFullScreen(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setFullScreen8798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFullScreen8798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFullScreen8799; 
		public bool isFullScreen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent._isFullScreen8799); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isFullScreen8799); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventType8800; 
		public int getEventType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getEventType8800); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventType8800); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventType8801; 
		public void setEventType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setEventType8801, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventType8801, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemCount8802; 
		public int getItemCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getItemCount8802); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getItemCount8802); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setItemCount8803; 
		public void setItemCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setItemCount8803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setItemCount8803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentItemIndex8804; 
		public int getCurrentItemIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex8804); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex8804); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentItemIndex8805; 
		public void setCurrentItemIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex8805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex8805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFromIndex8806; 
		public int getFromIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getFromIndex8806); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getFromIndex8806); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFromIndex8807; 
		public void setFromIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setFromIndex8807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFromIndex8807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddedCount8808; 
		public int getAddedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getAddedCount8808); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getAddedCount8808); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAddedCount8809; 
		public void setAddedCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setAddedCount8809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setAddedCount8809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemovedCount8810; 
		public int getRemovedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getRemovedCount8810); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getRemovedCount8810); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRemovedCount8811; 
		public void setRemovedCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setRemovedCount8811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setRemovedCount8811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventTime8812; 
		public long getEventTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.view.accessibility.AccessibilityEvent._getEventTime8812); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventTime8812); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventTime8813; 
		public void setEventTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setEventTime8813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventTime8813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClassName8814; 
		public void setClassName(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setClassName8814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setClassName8814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPackageName8815; 
		public void setPackageName(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setPackageName8815, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPackageName8815, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBeforeText8816; 
		public global::java.lang.CharSequence getBeforeText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getBeforeText8816)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getBeforeText8816)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBeforeText8817; 
		public void setBeforeText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setBeforeText8817, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setBeforeText8817, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentDescription8818; 
		public global::java.lang.CharSequence getContentDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getContentDescription8818)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getContentDescription8818)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentDescription8819; 
		public void setContentDescription(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setContentDescription8819, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setContentDescription8819, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableData8820; 
		public global::android.os.Parcelable getParcelableData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getParcelableData8820)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getParcelableData8820)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setParcelableData8821; 
		public void setParcelableData(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setParcelableData8821, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setParcelableData8821, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain8822; 
		public static global::android.view.accessibility.AccessibilityEvent obtain() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.accessibility.AccessibilityEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain8822)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain8823; 
		public static global::android.view.accessibility.AccessibilityEvent obtain(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.accessibility.AccessibilityEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain8823, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle8824; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._recycle8824); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._recycle8824); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initFromParcel8825; 
		public void initFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._initFromParcel8825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._initFromParcel8825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8826; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._writeToParcel8826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._writeToParcel8826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8827; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._describeContents8827); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._describeContents8827); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8828; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.accessibility.AccessibilityEvent.staticClass = @__class; 
			global::android.view.accessibility.AccessibilityEvent._toString8788 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.accessibility.AccessibilityEvent._getClassName8789 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getClassName", "()Ljava/lang/CharSequence;"); 
			global::android.view.accessibility.AccessibilityEvent._getPackageName8790 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getPackageName", "()Ljava/lang/CharSequence;"); 
			global::android.view.accessibility.AccessibilityEvent._getText8791 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getText", "()Ljava/util/List;"); 
			global::android.view.accessibility.AccessibilityEvent._isChecked8792 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isChecked", "()Z"); 
			global::android.view.accessibility.AccessibilityEvent._setChecked8793 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setChecked", "(Z)V"); 
			global::android.view.accessibility.AccessibilityEvent._isEnabled8794 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isEnabled", "()Z"); 
			global::android.view.accessibility.AccessibilityEvent._setEnabled8795 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEnabled", "(Z)V"); 
			global::android.view.accessibility.AccessibilityEvent._isPassword8796 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isPassword", "()Z"); 
			global::android.view.accessibility.AccessibilityEvent._setPassword8797 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPassword", "(Z)V"); 
			global::android.view.accessibility.AccessibilityEvent._setFullScreen8798 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFullScreen", "(Z)V"); 
			global::android.view.accessibility.AccessibilityEvent._isFullScreen8799 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isFullScreen", "()Z"); 
			global::android.view.accessibility.AccessibilityEvent._getEventType8800 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventType", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setEventType8801 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventType", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getItemCount8802 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getItemCount", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setItemCount8803 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setItemCount", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex8804 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getCurrentItemIndex", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex8805 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setCurrentItemIndex", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getFromIndex8806 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getFromIndex", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setFromIndex8807 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFromIndex", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getAddedCount8808 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getAddedCount", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setAddedCount8809 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setAddedCount", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getRemovedCount8810 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getRemovedCount", "()I"); 
			global::android.view.accessibility.AccessibilityEvent._setRemovedCount8811 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setRemovedCount", "(I)V"); 
			global::android.view.accessibility.AccessibilityEvent._getEventTime8812 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventTime", "()J"); 
			global::android.view.accessibility.AccessibilityEvent._setEventTime8813 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventTime", "(J)V"); 
			global::android.view.accessibility.AccessibilityEvent._setClassName8814 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setClassName", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.accessibility.AccessibilityEvent._setPackageName8815 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPackageName", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.accessibility.AccessibilityEvent._getBeforeText8816 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getBeforeText", "()Ljava/lang/CharSequence;"); 
			global::android.view.accessibility.AccessibilityEvent._setBeforeText8817 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setBeforeText", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.accessibility.AccessibilityEvent._getContentDescription8818 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;"); 
			global::android.view.accessibility.AccessibilityEvent._setContentDescription8819 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.accessibility.AccessibilityEvent._getParcelableData8820 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getParcelableData", "()Landroid/os/Parcelable;"); 
			global::android.view.accessibility.AccessibilityEvent._setParcelableData8821 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setParcelableData", "(Landroid/os/Parcelable;)V"); 
			global::android.view.accessibility.AccessibilityEvent._obtain8822 = @__env.GetStaticMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "()Landroid/view/accessibility/AccessibilityEvent;"); 
			global::android.view.accessibility.AccessibilityEvent._obtain8823 = @__env.GetStaticMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;"); 
			global::android.view.accessibility.AccessibilityEvent._recycle8824 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "recycle", "()V"); 
			global::android.view.accessibility.AccessibilityEvent._initFromParcel8825 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "initFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.view.accessibility.AccessibilityEvent._writeToParcel8826 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.accessibility.AccessibilityEvent._describeContents8827 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "describeContents", "()I"); 
		} 
	} 
	public static class AccessibilityEventExtensionMethods 
	{ 
		public static void setClassName(this global::android.view.accessibility.AccessibilityEvent __this, string arg0) 
		{ 
			__this.setClassName((global::java.lang.String)arg0); 
		} 
		public static void setPackageName(this global::android.view.accessibility.AccessibilityEvent __this, string arg0) 
		{ 
			__this.setPackageName((global::java.lang.String)arg0); 
		} 
		public static void setBeforeText(this global::android.view.accessibility.AccessibilityEvent __this, string arg0) 
		{ 
			__this.setBeforeText((global::java.lang.String)arg0); 
		} 
		public static void setContentDescription(this global::android.view.accessibility.AccessibilityEvent __this, string arg0) 
		{ 
			__this.setContentDescription((global::java.lang.String)arg0); 
		} 
	} 
} 
