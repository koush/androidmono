namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class MotionEvent : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static MotionEvent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.MotionEvent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString7935; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.MotionEvent._toString7935)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._toString7935)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSize7936; 
		public float getSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getSize7936); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize7936); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSize7937; 
		public float getSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getSize7937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize7937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getY7938; 
		public float getY(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getY7938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY7938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getY7939; 
		public float getY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getY7939); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY7939); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getX7940; 
		public float getX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getX7940); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX7940); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getX7941; 
		public float getX(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getX7941, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX7941, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventTime7942; 
		public long getEventTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallLongMethod(this, global::android.view.MotionEvent._getEventTime7942); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEventTime7942); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain7943; 
		public static global::android.view.MotionEvent obtain(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain7943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain7944; 
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, float arg5, float arg6, int arg7, float arg8, float arg9, int arg10, int arg11) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain7944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg11))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain7945; 
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain7945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain7946; 
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, int arg3, float arg4, float arg5, float arg6, float arg7, int arg8, float arg9, float arg10, int arg11, int arg12) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain7946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg11), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg12))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle7947; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._recycle7947); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._recycle7947); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7948; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._writeToParcel7948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._writeToParcel7948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7949; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._describeContents7949); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._describeContents7949); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAction7950; 
		public int getAction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getAction7950); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getAction7950); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAction7951; 
		public void setAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._setAction7951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setAction7951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState7952; 
		public int getMetaState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getMetaState7952); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getMetaState7952); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDownTime7953; 
		public long getDownTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallLongMethod(this, global::android.view.MotionEvent._getDownTime7953); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDownTime7953); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceId7954; 
		public int getDeviceId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getDeviceId7954); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDeviceId7954); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainNoHistory7955; 
		public static global::android.view.MotionEvent obtainNoHistory(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtainNoHistory7955, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPressure7956; 
		public float getPressure(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getPressure7956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure7956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPressure7957; 
		public float getPressure() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getPressure7957); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure7957); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPointerCount7958; 
		public int getPointerCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getPointerCount7958); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerCount7958); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPointerId7959; 
		public int getPointerId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getPointerId7959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerId7959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findPointerIndex7960; 
		public int findPointerIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._findPointerIndex7960, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._findPointerIndex7960, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawX7961; 
		public float getRawX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getRawX7961); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawX7961); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawY7962; 
		public float getRawY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getRawY7962); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawY7962); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getXPrecision7963; 
		public float getXPrecision() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getXPrecision7963); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getXPrecision7963); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYPrecision7964; 
		public float getYPrecision() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getYPrecision7964); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getYPrecision7964); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistorySize7965; 
		public int getHistorySize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getHistorySize7965); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistorySize7965); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalEventTime7966; 
		public long getHistoricalEventTime(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallLongMethod(this, global::android.view.MotionEvent._getHistoricalEventTime7966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalEventTime7966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalX7967; 
		public float getHistoricalX(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalX7967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX7967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalX7968; 
		public float getHistoricalX(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalX7968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX7968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalY7969; 
		public float getHistoricalY(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalY7969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY7969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalY7970; 
		public float getHistoricalY(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalY7970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY7970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalPressure7971; 
		public float getHistoricalPressure(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalPressure7971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure7971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalPressure7972; 
		public float getHistoricalPressure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalPressure7972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure7972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalSize7973; 
		public float getHistoricalSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalSize7973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize7973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalSize7974; 
		public float getHistoricalSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalSize7974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize7974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEdgeFlags7975; 
		public int getEdgeFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getEdgeFlags7975); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEdgeFlags7975); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEdgeFlags7976; 
		public void setEdgeFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._setEdgeFlags7976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setEdgeFlags7976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetLocation7977; 
		public void offsetLocation(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._offsetLocation7977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._offsetLocation7977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLocation7978; 
		public void setLocation(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._setLocation7978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setLocation7978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addBatch7979; 
		public void addBatch(long arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.MotionEvent)) 
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._addBatch7979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._addBatch7979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR7980; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.MotionEvent.staticClass = @__class; 
			global::android.view.MotionEvent._toString7935 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.MotionEvent._getSize7936 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getSize", "()F"); 
			global::android.view.MotionEvent._getSize7937 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getSize", "(I)F"); 
			global::android.view.MotionEvent._getY7938 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getY", "(I)F"); 
			global::android.view.MotionEvent._getY7939 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getY", "()F"); 
			global::android.view.MotionEvent._getX7940 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getX", "()F"); 
			global::android.view.MotionEvent._getX7941 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getX", "(I)F"); 
			global::android.view.MotionEvent._getEventTime7942 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getEventTime", "()J"); 
			global::android.view.MotionEvent._obtain7943 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._obtain7944 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._obtain7945 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFI)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._obtain7946 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(JJIIFFFFIFFII)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._recycle7947 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "recycle", "()V"); 
			global::android.view.MotionEvent._writeToParcel7948 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.MotionEvent._describeContents7949 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "describeContents", "()I"); 
			global::android.view.MotionEvent._getAction7950 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getAction", "()I"); 
			global::android.view.MotionEvent._setAction7951 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "setAction", "(I)V"); 
			global::android.view.MotionEvent._getMetaState7952 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getMetaState", "()I"); 
			global::android.view.MotionEvent._getDownTime7953 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getDownTime", "()J"); 
			global::android.view.MotionEvent._getDeviceId7954 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getDeviceId", "()I"); 
			global::android.view.MotionEvent._obtainNoHistory7955 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;"); 
			global::android.view.MotionEvent._getPressure7956 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPressure", "(I)F"); 
			global::android.view.MotionEvent._getPressure7957 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPressure", "()F"); 
			global::android.view.MotionEvent._getPointerCount7958 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPointerCount", "()I"); 
			global::android.view.MotionEvent._getPointerId7959 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPointerId", "(I)I"); 
			global::android.view.MotionEvent._findPointerIndex7960 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "findPointerIndex", "(I)I"); 
			global::android.view.MotionEvent._getRawX7961 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getRawX", "()F"); 
			global::android.view.MotionEvent._getRawY7962 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getRawY", "()F"); 
			global::android.view.MotionEvent._getXPrecision7963 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getXPrecision", "()F"); 
			global::android.view.MotionEvent._getYPrecision7964 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getYPrecision", "()F"); 
			global::android.view.MotionEvent._getHistorySize7965 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistorySize", "()I"); 
			global::android.view.MotionEvent._getHistoricalEventTime7966 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalEventTime", "(I)J"); 
			global::android.view.MotionEvent._getHistoricalX7967 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(II)F"); 
			global::android.view.MotionEvent._getHistoricalX7968 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(I)F"); 
			global::android.view.MotionEvent._getHistoricalY7969 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(I)F"); 
			global::android.view.MotionEvent._getHistoricalY7970 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(II)F"); 
			global::android.view.MotionEvent._getHistoricalPressure7971 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(I)F"); 
			global::android.view.MotionEvent._getHistoricalPressure7972 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(II)F"); 
			global::android.view.MotionEvent._getHistoricalSize7973 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(II)F"); 
			global::android.view.MotionEvent._getHistoricalSize7974 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(I)F"); 
			global::android.view.MotionEvent._getEdgeFlags7975 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getEdgeFlags", "()I"); 
			global::android.view.MotionEvent._setEdgeFlags7976 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "setEdgeFlags", "(I)V"); 
			global::android.view.MotionEvent._offsetLocation7977 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "offsetLocation", "(FF)V"); 
			global::android.view.MotionEvent._setLocation7978 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "setLocation", "(FF)V"); 
			global::android.view.MotionEvent._addBatch7979 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "addBatch", "(JFFFFI)V"); 
		} 
	} 
} 
