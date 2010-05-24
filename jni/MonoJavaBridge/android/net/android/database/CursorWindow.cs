namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CursorWindow : android.database.sqlite.SQLiteClosable, android.os.Parcelable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CursorWindow() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.CursorWindow), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.CursorWindow(@__env); 
			} 
		} 
		protected CursorWindow(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort2264; 
		public virtual short getShort(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallShortMethod(this, _getShort2264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, android.database.CursorWindow.staticClass, _getShort2264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2265; 
		public virtual int getInt(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallIntMethod(this, _getInt2265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWindow.staticClass, _getInt2265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2266; 
		public virtual long getLong(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallLongMethod(this, _getLong2266, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.CursorWindow.staticClass, _getLong2266, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putLong2267; 
		public virtual bool putLong(long arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putLong2267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putLong2267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2268; 
		public virtual float getFloat(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallFloatMethod(this, _getFloat2268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.database.CursorWindow.staticClass, _getFloat2268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2269; 
		public virtual double getDouble(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallDoubleMethod(this, _getDouble2269, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.database.CursorWindow.staticClass, _getDouble2269, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putDouble2270; 
		public virtual bool putDouble(double arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putDouble2270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putDouble2270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear2271; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _clear2271); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _clear2271); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2272; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _close2272); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _close2272); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2273; 
		public virtual java.lang.String getString(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString2273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWindow.staticClass, _getString2273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putNull2274; 
		public virtual bool putNull(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putNull2274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putNull2274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2275; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _writeToParcel2275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _writeToParcel2275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2276; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallIntMethod(this, _describeContents2276); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWindow.staticClass, _describeContents2276); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleased2277; 
		protected override void onAllReferencesReleased() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _onAllReferencesReleased2277); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _onAllReferencesReleased2277); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putString2278; 
		public virtual bool putString(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putString2278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putString2278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2279; 
		public virtual byte[] getBlob(int arg0, int arg1) 
		{ 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getBlob2279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWindow.staticClass, _getBlob2279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2280; 
		public virtual void copyStringToBuffer(int arg0, int arg1, android.database.CharArrayBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _copyStringToBuffer2280, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _copyStringToBuffer2280, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2281; 
		public virtual bool isNull(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isNull2281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isNull2281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartPosition2282; 
		public virtual int getStartPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallIntMethod(this, _getStartPosition2282); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWindow.staticClass, _getStartPosition2282); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartPosition2283; 
		public virtual void setStartPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _setStartPosition2283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _setStartPosition2283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumRows2284; 
		public virtual int getNumRows() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallIntMethod(this, _getNumRows2284); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWindow.staticClass, _getNumRows2284); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNumColumns2285; 
		public virtual bool setNumColumns(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _setNumColumns2285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _setNumColumns2285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocRow2286; 
		public virtual bool allocRow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _allocRow2286); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _allocRow2286); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _freeLastRow2287; 
		public virtual void freeLastRow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _freeLastRow2287); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _freeLastRow2287); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putBlob2288; 
		public virtual bool putBlob(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putBlob2288, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putBlob2288, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBlob2289; 
		public virtual bool isBlob(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isBlob2289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isBlob2289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLong2290; 
		public virtual bool isLong(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isLong2290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isLong2290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFloat2291; 
		public virtual bool isFloat(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isFloat2291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isFloat2291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isString2292; 
		public virtual bool isString(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isString2292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isString2292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newFromParcel2293; 
		public static android.database.CursorWindow newFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallStaticObjectMethodPtr(android.database.CursorWindow.staticClass, _newFromParcel2293, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorWindow2294; 
		public CursorWindow(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.CursorWindow.staticClass, _CursorWindow2294, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2295; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.CursorWindow.staticClass = @__class; 
			global::android.database.CursorWindow._getShort2264 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getShort", "(II)S"); 
			global::android.database.CursorWindow._getInt2265 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getInt", "(II)I"); 
			global::android.database.CursorWindow._getLong2266 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getLong", "(II)J"); 
			global::android.database.CursorWindow._putLong2267 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putLong", "(JII)Z"); 
			global::android.database.CursorWindow._getFloat2268 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getFloat", "(II)F"); 
			global::android.database.CursorWindow._getDouble2269 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getDouble", "(II)D"); 
			global::android.database.CursorWindow._putDouble2270 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putDouble", "(DII)Z"); 
			global::android.database.CursorWindow._clear2271 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "clear", "()V"); 
			global::android.database.CursorWindow._close2272 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "close", "()V"); 
			global::android.database.CursorWindow._getString2273 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getString", "(II)Ljava/lang/String;"); 
			global::android.database.CursorWindow._putNull2274 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putNull", "(II)Z"); 
			global::android.database.CursorWindow._writeToParcel2275 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.database.CursorWindow._describeContents2276 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "describeContents", "()I"); 
			global::android.database.CursorWindow._onAllReferencesReleased2277 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "onAllReferencesReleased", "()V"); 
			global::android.database.CursorWindow._putString2278 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putString", "(Ljava/lang/String;II)Z"); 
			global::android.database.CursorWindow._getBlob2279 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getBlob", "(II)[B"); 
			global::android.database.CursorWindow._copyStringToBuffer2280 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "copyStringToBuffer", "(IILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.CursorWindow._isNull2281 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isNull", "(II)Z"); 
			global::android.database.CursorWindow._getStartPosition2282 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getStartPosition", "()I"); 
			global::android.database.CursorWindow._setStartPosition2283 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "setStartPosition", "(I)V"); 
			global::android.database.CursorWindow._getNumRows2284 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getNumRows", "()I"); 
			global::android.database.CursorWindow._setNumColumns2285 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "setNumColumns", "(I)Z"); 
			global::android.database.CursorWindow._allocRow2286 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "allocRow", "()Z"); 
			global::android.database.CursorWindow._freeLastRow2287 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "freeLastRow", "()V"); 
			global::android.database.CursorWindow._putBlob2288 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putBlob", "([BII)Z"); 
			global::android.database.CursorWindow._isBlob2289 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isBlob", "(II)Z"); 
			global::android.database.CursorWindow._isLong2290 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isLong", "(II)Z"); 
			global::android.database.CursorWindow._isFloat2291 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isFloat", "(II)Z"); 
			global::android.database.CursorWindow._isString2292 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isString", "(II)Z"); 
			global::android.database.CursorWindow._newFromParcel2293 = @__env.GetStaticMethodID(global::android.database.CursorWindow.staticClass, "newFromParcel", "(Landroid/os/Parcel;)Landroid/database/CursorWindow;"); 
			global::android.database.CursorWindow._CursorWindow2294 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "<init>", "(Z)V"); 
		} 
	} 
} 
