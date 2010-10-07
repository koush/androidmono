namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbstractCursor : java.lang.Object, CrossProcessCursor
	{
		internal static global::java.lang.Class staticClass;
		static AbstractCursor()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.AbstractCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbstractCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		protected class SelfContentObserver : android.database.ContentObserver
		{
			internal new static global::java.lang.Class staticClass;
			static SelfContentObserver()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.AbstractCursor.SelfContentObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.database.AbstractCursor.SelfContentObserver(@__env);
				}
			}
			protected SelfContentObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _deliverSelfNotifications2275;
			public override bool deliverSelfNotifications() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications2275);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications2275);
			}
			internal static global::net.sf.jni4net.jni.MethodId _onChange2276;
			public override void onChange(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.AbstractCursor.SelfContentObserver._onChange2276, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._onChange2276, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _SelfContentObserver2277;
			public SelfContentObserver(android.database.AbstractCursor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver2277, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.database.AbstractCursor.SelfContentObserver.staticClass = @__class;
				global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications2275 = @__env.GetMethodID(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "deliverSelfNotifications", "()Z");
				global::android.database.AbstractCursor.SelfContentObserver._onChange2276 = @__env.GetMethodID(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "onChange", "(Z)V");
				global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver2277 = @__env.GetMethodID(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "<init>", "(Landroid/database/AbstractCursor;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort2278;
		public abstract short getShort(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getInt2279;
		public abstract int getInt(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getLong2280;
		public abstract long getLong(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2281;
		public abstract float getFloat(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2282;
		public abstract double getDouble(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _close2283;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._close2283);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._close2283);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2284;
		public abstract global::java.lang.String getString(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _isFirst2285;
		public virtual bool isFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._isFirst2285);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isFirst2285);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2286;
		public virtual bool isClosed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._isClosed2286);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isClosed2286);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2287;
		public virtual int getPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.AbstractCursor._getPosition2287);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getPosition2287);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2288;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractCursor._getExtras2288));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getExtras2288));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2289;
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._registerContentObserver2289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._registerContentObserver2289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2290;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._unregisterContentObserver2290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._unregisterContentObserver2290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindow2291;
		public virtual global::android.database.CursorWindow getWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractCursor._getWindow2291));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getWindow2291));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount2292;
		public abstract int getCount();
		internal static global::net.sf.jni4net.jni.MethodId _move2293;
		public virtual bool move(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._move2293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._move2293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2294;
		public virtual bool moveToPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._moveToPosition2294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToPosition2294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2295;
		public virtual bool moveToFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._moveToFirst2295);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToFirst2295);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2296;
		public virtual bool moveToLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._moveToLast2296);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToLast2296);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2297;
		public virtual bool moveToNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._moveToNext2297);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToNext2297);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2298;
		public virtual bool moveToPrevious() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._moveToPrevious2298);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToPrevious2298);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLast2299;
		public virtual bool isLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._isLast2299);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isLast2299);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2300;
		public virtual bool isBeforeFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._isBeforeFirst2300);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isBeforeFirst2300);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2301;
		public virtual bool isAfterLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._isAfterLast2301);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isAfterLast2301);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2302;
		public virtual int getColumnIndex(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.AbstractCursor._getColumnIndex2302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnIndex2302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2303;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.AbstractCursor._getColumnIndexOrThrow2303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnIndexOrThrow2303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2304;
		public virtual global::java.lang.String getColumnName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractCursor._getColumnName2304, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnName2304, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2305;
		public abstract global::java.lang.String[] getColumnNames();
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2306;
		public virtual int getColumnCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.AbstractCursor._getColumnCount2306);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnCount2306);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2307;
		public virtual byte[] getBlob(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractCursor._getBlob2307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getBlob2307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2308;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._copyStringToBuffer2308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._copyStringToBuffer2308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNull2309;
		public abstract bool isNull(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2310;
		public virtual void deactivate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._deactivate2310);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._deactivate2310);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requery2311;
		public virtual bool requery() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._requery2311);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._requery2311);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2312;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._registerDataSetObserver2312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._registerDataSetObserver2312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2313;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._unregisterDataSetObserver2313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._unregisterDataSetObserver2313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2314;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._setNotificationUri2314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._setNotificationUri2314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2315;
		public virtual bool getWantsAllOnMoveCalls() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._getWantsAllOnMoveCalls2315);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getWantsAllOnMoveCalls2315);
		}
		internal static global::net.sf.jni4net.jni.MethodId _respond2316;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractCursor._respond2316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._respond2316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChange2317;
		protected virtual void onChange(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._onChange2317, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._onChange2317, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMove2318;
		public virtual bool onMove(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._onMove2318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._onMove2318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fillWindow2319;
		public virtual void fillWindow(int arg0, android.database.CursorWindow arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._fillWindow2319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._fillWindow2319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFieldUpdated2320;
		protected virtual bool isFieldUpdated(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.AbstractCursor._isFieldUpdated2320, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isFieldUpdated2320, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUpdatedField2321;
		protected virtual global::java.lang.Object getUpdatedField(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.AbstractCursor._getUpdatedField2321, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getUpdatedField2321, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkPosition2322;
		protected virtual void checkPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.AbstractCursor._checkPosition2322);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._checkPosition2322);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbstractCursor2323;
		public AbstractCursor()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._AbstractCursor2323, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.AbstractCursor.staticClass = @__class;
			global::android.database.AbstractCursor._getShort2278 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getShort", "(I)S");
			global::android.database.AbstractCursor._getInt2279 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getInt", "(I)I");
			global::android.database.AbstractCursor._getLong2280 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getLong", "(I)J");
			global::android.database.AbstractCursor._getFloat2281 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getFloat", "(I)F");
			global::android.database.AbstractCursor._getDouble2282 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getDouble", "(I)D");
			global::android.database.AbstractCursor._close2283 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "close", "()V");
			global::android.database.AbstractCursor._getString2284 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.AbstractCursor._isFirst2285 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isFirst", "()Z");
			global::android.database.AbstractCursor._isClosed2286 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isClosed", "()Z");
			global::android.database.AbstractCursor._getPosition2287 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getPosition", "()I");
			global::android.database.AbstractCursor._getExtras2288 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.AbstractCursor._registerContentObserver2289 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.AbstractCursor._unregisterContentObserver2290 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.AbstractCursor._getWindow2291 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.AbstractCursor._getCount2292 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getCount", "()I");
			global::android.database.AbstractCursor._move2293 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "move", "(I)Z");
			global::android.database.AbstractCursor._moveToPosition2294 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToPosition", "(I)Z");
			global::android.database.AbstractCursor._moveToFirst2295 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToFirst", "()Z");
			global::android.database.AbstractCursor._moveToLast2296 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToLast", "()Z");
			global::android.database.AbstractCursor._moveToNext2297 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToNext", "()Z");
			global::android.database.AbstractCursor._moveToPrevious2298 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToPrevious", "()Z");
			global::android.database.AbstractCursor._isLast2299 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isLast", "()Z");
			global::android.database.AbstractCursor._isBeforeFirst2300 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isBeforeFirst", "()Z");
			global::android.database.AbstractCursor._isAfterLast2301 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isAfterLast", "()Z");
			global::android.database.AbstractCursor._getColumnIndex2302 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.AbstractCursor._getColumnIndexOrThrow2303 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.AbstractCursor._getColumnName2304 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.AbstractCursor._getColumnNames2305 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.AbstractCursor._getColumnCount2306 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnCount", "()I");
			global::android.database.AbstractCursor._getBlob2307 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.AbstractCursor._copyStringToBuffer2308 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.AbstractCursor._isNull2309 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isNull", "(I)Z");
			global::android.database.AbstractCursor._deactivate2310 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "deactivate", "()V");
			global::android.database.AbstractCursor._requery2311 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "requery", "()Z");
			global::android.database.AbstractCursor._registerDataSetObserver2312 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.AbstractCursor._unregisterDataSetObserver2313 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.AbstractCursor._setNotificationUri2314 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.AbstractCursor._getWantsAllOnMoveCalls2315 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.AbstractCursor._respond2316 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.database.AbstractCursor._onChange2317 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "onChange", "(Z)V");
			global::android.database.AbstractCursor._onMove2318 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "onMove", "(II)Z");
			global::android.database.AbstractCursor._fillWindow2319 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V");
			global::android.database.AbstractCursor._isFieldUpdated2320 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isFieldUpdated", "(I)Z");
			global::android.database.AbstractCursor._getUpdatedField2321 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getUpdatedField", "(I)Ljava/lang/Object;");
			global::android.database.AbstractCursor._checkPosition2322 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "checkPosition", "()V");
			global::android.database.AbstractCursor._AbstractCursor2323 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "<init>", "()V");
		}
	}
}
