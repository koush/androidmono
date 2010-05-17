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
		internal static global::net.sf.jni4net.jni.MethodId _getShort2080; 
		public virtual short getShort(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallShortMethod(this, _getShort2080, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, android.database.CursorWindow.staticClass, _getShort2080, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2081; 
		public virtual int getInt(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallIntMethod(this, _getInt2081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWindow.staticClass, _getInt2081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2082; 
		public virtual long getLong(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallLongMethod(this, _getLong2082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.CursorWindow.staticClass, _getLong2082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putLong2083; 
		public virtual bool putLong(long arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putLong2083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putLong2083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2084; 
		public virtual float getFloat(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallFloatMethod(this, _getFloat2084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.database.CursorWindow.staticClass, _getFloat2084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2085; 
		public virtual double getDouble(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallDoubleMethod(this, _getDouble2085, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.database.CursorWindow.staticClass, _getDouble2085, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putDouble2086; 
		public virtual bool putDouble(double arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putDouble2086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putDouble2086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear2087; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _clear2087); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _clear2087); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2088; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _close2088); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _close2088); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2089; 
		public virtual java.lang.String getString(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString2089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWindow.staticClass, _getString2089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putNull2090; 
		public virtual bool putNull(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putNull2090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putNull2090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2091; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _writeToParcel2091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _writeToParcel2091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2092; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallIntMethod(this, _describeContents2092); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWindow.staticClass, _describeContents2092); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleased2093; 
		protected override void onAllReferencesReleased() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _onAllReferencesReleased2093); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _onAllReferencesReleased2093); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putString2094; 
		public virtual bool putString(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putString2094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putString2094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2095; 
		public virtual byte[] getBlob(int arg0, int arg1) 
		{ 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getBlob2095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWindow.staticClass, _getBlob2095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2096; 
		public virtual void copyStringToBuffer(int arg0, int arg1, android.database.CharArrayBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _copyStringToBuffer2096, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _copyStringToBuffer2096, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2097; 
		public virtual bool isNull(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isNull2097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isNull2097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartPosition2098; 
		public virtual int getStartPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallIntMethod(this, _getStartPosition2098); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWindow.staticClass, _getStartPosition2098); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartPosition2099; 
		public virtual void setStartPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _setStartPosition2099, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _setStartPosition2099, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumRows2100; 
		public virtual int getNumRows() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallIntMethod(this, _getNumRows2100); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWindow.staticClass, _getNumRows2100); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNumColumns2101; 
		public virtual bool setNumColumns(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _setNumColumns2101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _setNumColumns2101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocRow2102; 
		public virtual bool allocRow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _allocRow2102); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _allocRow2102); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _freeLastRow2103; 
		public virtual void freeLastRow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				@__env.CallVoidMethod(this, _freeLastRow2103); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWindow.staticClass, _freeLastRow2103); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putBlob2104; 
		public virtual bool putBlob(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _putBlob2104, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _putBlob2104, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBlob2105; 
		public virtual bool isBlob(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isBlob2105, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isBlob2105, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLong2106; 
		public virtual bool isLong(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isLong2106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isLong2106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFloat2107; 
		public virtual bool isFloat(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isFloat2107, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isFloat2107, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isString2108; 
		public virtual bool isString(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWindow)) 
				return @__env.CallBooleanMethod(this, _isString2108, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWindow.staticClass, _isString2108, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newFromParcel2109; 
		public static android.database.CursorWindow newFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallStaticObjectMethodPtr(android.database.CursorWindow.staticClass, _newFromParcel2109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorWindow2110; 
		public CursorWindow(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.CursorWindow.staticClass, _CursorWindow2110, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2111; 
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
			global::android.database.CursorWindow._getShort2080 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getShort", "(II)S"); 
			global::android.database.CursorWindow._getInt2081 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getInt", "(II)I"); 
			global::android.database.CursorWindow._getLong2082 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getLong", "(II)J"); 
			global::android.database.CursorWindow._putLong2083 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putLong", "(JII)Z"); 
			global::android.database.CursorWindow._getFloat2084 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getFloat", "(II)F"); 
			global::android.database.CursorWindow._getDouble2085 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getDouble", "(II)D"); 
			global::android.database.CursorWindow._putDouble2086 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putDouble", "(DII)Z"); 
			global::android.database.CursorWindow._clear2087 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "clear", "()V"); 
			global::android.database.CursorWindow._close2088 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "close", "()V"); 
			global::android.database.CursorWindow._getString2089 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getString", "(II)Ljava/lang/String;"); 
			global::android.database.CursorWindow._putNull2090 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putNull", "(II)Z"); 
			global::android.database.CursorWindow._writeToParcel2091 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.database.CursorWindow._describeContents2092 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "describeContents", "()I"); 
			global::android.database.CursorWindow._onAllReferencesReleased2093 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "onAllReferencesReleased", "()V"); 
			global::android.database.CursorWindow._putString2094 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putString", "(Ljava/lang/String;II)Z"); 
			global::android.database.CursorWindow._getBlob2095 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getBlob", "(II)[B"); 
			global::android.database.CursorWindow._copyStringToBuffer2096 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "copyStringToBuffer", "(IILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.CursorWindow._isNull2097 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isNull", "(II)Z"); 
			global::android.database.CursorWindow._getStartPosition2098 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getStartPosition", "()I"); 
			global::android.database.CursorWindow._setStartPosition2099 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "setStartPosition", "(I)V"); 
			global::android.database.CursorWindow._getNumRows2100 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getNumRows", "()I"); 
			global::android.database.CursorWindow._setNumColumns2101 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "setNumColumns", "(I)Z"); 
			global::android.database.CursorWindow._allocRow2102 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "allocRow", "()Z"); 
			global::android.database.CursorWindow._freeLastRow2103 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "freeLastRow", "()V"); 
			global::android.database.CursorWindow._putBlob2104 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putBlob", "([BII)Z"); 
			global::android.database.CursorWindow._isBlob2105 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isBlob", "(II)Z"); 
			global::android.database.CursorWindow._isLong2106 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isLong", "(II)Z"); 
			global::android.database.CursorWindow._isFloat2107 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isFloat", "(II)Z"); 
			global::android.database.CursorWindow._isString2108 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isString", "(II)Z"); 
			global::android.database.CursorWindow._newFromParcel2109 = @__env.GetStaticMethodID(global::android.database.CursorWindow.staticClass, "newFromParcel", "(Landroid/os/Parcel;)Landroid/database/CursorWindow;"); 
			global::android.database.CursorWindow._CursorWindow2110 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "<init>", "(Z)V"); 
		} 
	} 
} 
