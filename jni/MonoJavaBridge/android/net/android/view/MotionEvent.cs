namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class MotionEvent : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static MotionEvent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.MotionEvent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.MotionEvent(@__env); 
			} 
		} 
		internal MotionEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString7432; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString7432)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.MotionEvent.staticClass, _toString7432)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSize7433; 
		public float getSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getSize7433); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getSize7433); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSize7434; 
		public float getSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getSize7434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getSize7434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getY7435; 
		public float getY(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getY7435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getY7435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getY7436; 
		public float getY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getY7436); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getY7436); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getX7437; 
		public float getX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getX7437); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getX7437); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getX7438; 
		public float getX(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getX7438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getX7438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventTime7439; 
		public long getEventTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallLongMethod(this, _getEventTime7439); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.MotionEvent.staticClass, _getEventTime7439); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain7440; 
		public static android.view.MotionEvent obtain(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, _obtain7440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain7441; 
		public static android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, float arg5, float arg6, int arg7, float arg8, float arg9, int arg10, int arg11) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, _obtain7441, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg11))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain7442; 
		public static android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, _obtain7442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain7443; 
		public static android.view.MotionEvent obtain(long arg0, long arg1, int arg2, int arg3, float arg4, float arg5, float arg6, float arg7, int arg8, float arg9, float arg10, int arg11, int arg12) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, _obtain7443, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg11), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg12))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle7444; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, _recycle7444); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.MotionEvent.staticClass, _recycle7444); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7445; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, _writeToParcel7445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.MotionEvent.staticClass, _writeToParcel7445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7446; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, _describeContents7446); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.MotionEvent.staticClass, _describeContents7446); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAction7447; 
		public int getAction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, _getAction7447); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.MotionEvent.staticClass, _getAction7447); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAction7448; 
		public void setAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, _setAction7448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.MotionEvent.staticClass, _setAction7448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState7449; 
		public int getMetaState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, _getMetaState7449); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.MotionEvent.staticClass, _getMetaState7449); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDownTime7450; 
		public long getDownTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallLongMethod(this, _getDownTime7450); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.MotionEvent.staticClass, _getDownTime7450); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceId7451; 
		public int getDeviceId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, _getDeviceId7451); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.MotionEvent.staticClass, _getDeviceId7451); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainNoHistory7452; 
		public static android.view.MotionEvent obtainNoHistory(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, _obtainNoHistory7452, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPressure7453; 
		public float getPressure(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getPressure7453, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getPressure7453, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPressure7454; 
		public float getPressure() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getPressure7454); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getPressure7454); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPointerCount7455; 
		public int getPointerCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, _getPointerCount7455); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.MotionEvent.staticClass, _getPointerCount7455); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPointerId7456; 
		public int getPointerId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, _getPointerId7456, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.MotionEvent.staticClass, _getPointerId7456, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findPointerIndex7457; 
		public int findPointerIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, _findPointerIndex7457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.MotionEvent.staticClass, _findPointerIndex7457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawX7458; 
		public float getRawX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getRawX7458); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getRawX7458); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawY7459; 
		public float getRawY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getRawY7459); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getRawY7459); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getXPrecision7460; 
		public float getXPrecision() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getXPrecision7460); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getXPrecision7460); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYPrecision7461; 
		public float getYPrecision() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getYPrecision7461); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getYPrecision7461); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistorySize7462; 
		public int getHistorySize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, _getHistorySize7462); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.MotionEvent.staticClass, _getHistorySize7462); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalEventTime7463; 
		public long getHistoricalEventTime(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallLongMethod(this, _getHistoricalEventTime7463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.MotionEvent.staticClass, _getHistoricalEventTime7463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalX7464; 
		public float getHistoricalX(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getHistoricalX7464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getHistoricalX7464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalX7465; 
		public float getHistoricalX(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getHistoricalX7465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getHistoricalX7465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalY7466; 
		public float getHistoricalY(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getHistoricalY7466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getHistoricalY7466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalY7467; 
		public float getHistoricalY(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getHistoricalY7467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getHistoricalY7467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalPressure7468; 
		public float getHistoricalPressure(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getHistoricalPressure7468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getHistoricalPressure7468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalPressure7469; 
		public float getHistoricalPressure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getHistoricalPressure7469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getHistoricalPressure7469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalSize7470; 
		public float getHistoricalSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getHistoricalSize7470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getHistoricalSize7470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalSize7471; 
		public float getHistoricalSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, _getHistoricalSize7471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.MotionEvent.staticClass, _getHistoricalSize7471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEdgeFlags7472; 
		public int getEdgeFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, _getEdgeFlags7472); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.MotionEvent.staticClass, _getEdgeFlags7472); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEdgeFlags7473; 
		public void setEdgeFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, _setEdgeFlags7473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.MotionEvent.staticClass, _setEdgeFlags7473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetLocation7474; 
		public void offsetLocation(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, _offsetLocation7474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.MotionEvent.staticClass, _offsetLocation7474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLocation7475; 
		public void setLocation(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, _setLocation7475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.MotionEvent.staticClass, _setLocation7475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addBatch7476; 
		public void addBatch(long arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, _addBatch7476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.MotionEvent.staticClass, _addBatch7476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		public static int ACTION_MASK
		{ 
			get 
			{ 
				return 255; 
			} 
		} 
		public static int ACTION_DOWN
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int ACTION_UP
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int ACTION_MOVE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int ACTION_CANCEL
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int ACTION_OUTSIDE
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int ACTION_POINTER_DOWN
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int ACTION_POINTER_1_DOWN
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int ACTION_POINTER_2_DOWN
		{ 
			get 
			{ 
				return 261; 
			} 
		} 
		public static int ACTION_POINTER_3_DOWN
		{ 
			get 
			{ 
				return 517; 
			} 
		} 
		public static int ACTION_POINTER_UP
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		public static int ACTION_POINTER_1_UP
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		public static int ACTION_POINTER_2_UP
		{ 
			get 
			{ 
				return 262; 
			} 
		} 
		public static int ACTION_POINTER_3_UP
		{ 
			get 
			{ 
				return 518; 
			} 
		} 
		public static int ACTION_POINTER_ID_MASK
		{ 
			get 
			{ 
				return 65280; 
			} 
		} 
		public static int ACTION_POINTER_ID_SHIFT
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int EDGE_TOP
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int EDGE_BOTTOM
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int EDGE_LEFT
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int EDGE_RIGHT
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR7477; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.MotionEvent.staticClass = @__class; 
			global::android.view.MotionEvent._toString7432 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.MotionEvent._getSize7433 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getSize", "()F"); 
			global::android.view.MotionEvent._getSize7434 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getSize", "(I)F"); 
			global::android.view.MotionEvent._getY7435 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getY", "(I)F"); 
			global::android.view.MotionEvent._getY7436 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getY", "()F"); 
			global::android.view.MotionEvent._getX7437 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getX", "()F"); 
			global::android.view.MotionEvent._getX7438 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getX", "(I)F"); 
			global::android.view.MotionEvent._getEventTime7439 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getEventTime", "()J"); 
			global::android.view.MotionEvent._obtain7440 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._obtain7441 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._obtain7442 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFI)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._obtain7443 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(JJIIFFFFIFFII)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._recycle7444 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "recycle", "()V"); 
			global::android.view.MotionEvent._writeToParcel7445 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.MotionEvent._describeContents7446 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "describeContents", "()I"); 
			global::android.view.MotionEvent._getAction7447 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getAction", "()I"); 
			global::android.view.MotionEvent._setAction7448 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "setAction", "(I)V"); 
			global::android.view.MotionEvent._getMetaState7449 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getMetaState", "()I"); 
			global::android.view.MotionEvent._getDownTime7450 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getDownTime", "()J"); 
			global::android.view.MotionEvent._getDeviceId7451 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getDeviceId", "()I"); 
			global::android.view.MotionEvent._obtainNoHistory7452 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._getPressure7453 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPressure", "(I)F"); 
			global::android.view.MotionEvent._getPressure7454 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPressure", "()F"); 
			global::android.view.MotionEvent._getPointerCount7455 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPointerCount", "()I"); 
			global::android.view.MotionEvent._getPointerId7456 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPointerId", "(I)I"); 
			global::android.view.MotionEvent._findPointerIndex7457 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "findPointerIndex", "(I)I"); 
			global::android.view.MotionEvent._getRawX7458 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getRawX", "()F"); 
			global::android.view.MotionEvent._getRawY7459 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getRawY", "()F"); 
			global::android.view.MotionEvent._getXPrecision7460 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getXPrecision", "()F"); 
			global::android.view.MotionEvent._getYPrecision7461 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getYPrecision", "()F"); 
			global::android.view.MotionEvent._getHistorySize7462 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistorySize", "()I"); 
			global::android.view.MotionEvent._getHistoricalEventTime7463 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalEventTime", "(I)J"); 
			global::android.view.MotionEvent._getHistoricalX7464 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(II)F"); 
			global::android.view.MotionEvent._getHistoricalX7465 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(I)F"); 
			global::android.view.MotionEvent._getHistoricalY7466 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(I)F"); 
			global::android.view.MotionEvent._getHistoricalY7467 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(II)F"); 
			global::android.view.MotionEvent._getHistoricalPressure7468 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(I)F"); 
			global::android.view.MotionEvent._getHistoricalPressure7469 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(II)F"); 
			global::android.view.MotionEvent._getHistoricalSize7470 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(II)F"); 
			global::android.view.MotionEvent._getHistoricalSize7471 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(I)F"); 
			global::android.view.MotionEvent._getEdgeFlags7472 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getEdgeFlags", "()I"); 
			global::android.view.MotionEvent._setEdgeFlags7473 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "setEdgeFlags", "(I)V"); 
			global::android.view.MotionEvent._offsetLocation7474 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "offsetLocation", "(FF)V"); 
			global::android.view.MotionEvent._setLocation7475 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "setLocation", "(FF)V"); 
			global::android.view.MotionEvent._addBatch7476 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "addBatch", "(JFFFFI)V"); 
		} 
	} 
} 
