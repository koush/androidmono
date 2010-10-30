namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLInput_))]
	public partial interface SQLInput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object readObject();
		int readInt();
		byte[] readBytes();
		long readLong();
		byte readByte();
		short readShort();
		float readFloat();
		bool readBoolean();
		double readDouble();
		global::java.lang.String readString();
		global::java.sql.Array readArray();
		bool wasNull();
		global::java.math.BigDecimal readBigDecimal();
		global::java.sql.Date readDate();
		global::java.sql.Time readTime();
		global::java.sql.Timestamp readTimestamp();
		global::java.io.Reader readCharacterStream();
		global::java.io.InputStream readAsciiStream();
		global::java.io.InputStream readBinaryStream();
		global::java.sql.Ref readRef();
		global::java.sql.Blob readBlob();
		global::java.sql.Clob readClob();
		global::java.net.URL readURL();
		global::java.lang.String readNString();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLInput))]
	internal sealed partial class SQLInput_ : java.lang.Object, SQLInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readObject24983;
		global::java.lang.Object java.sql.SQLInput.readObject()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readObject", "()Ljava/lang/Object;", ref global::java.sql.SQLInput_._readObject24983) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readInt24984;
		int java.sql.SQLInput.readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.SQLInput_.staticClass, "readInt", "()I", ref global::java.sql.SQLInput_._readInt24984);
		}
		internal static global::MonoJavaBridge.MethodId _readBytes24985;
		byte[] java.sql.SQLInput.readBytes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.sql.SQLInput_.staticClass, "readBytes", "()[B", ref global::java.sql.SQLInput_._readBytes24985) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _readLong24986;
		long java.sql.SQLInput.readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.SQLInput_.staticClass, "readLong", "()J", ref global::java.sql.SQLInput_._readLong24986);
		}
		internal static global::MonoJavaBridge.MethodId _readByte24987;
		byte java.sql.SQLInput.readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.sql.SQLInput_.staticClass, "readByte", "()B", ref global::java.sql.SQLInput_._readByte24987);
		}
		internal static global::MonoJavaBridge.MethodId _readShort24988;
		short java.sql.SQLInput.readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.sql.SQLInput_.staticClass, "readShort", "()S", ref global::java.sql.SQLInput_._readShort24988);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat24989;
		float java.sql.SQLInput.readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.sql.SQLInput_.staticClass, "readFloat", "()F", ref global::java.sql.SQLInput_._readFloat24989);
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean24990;
		bool java.sql.SQLInput.readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.SQLInput_.staticClass, "readBoolean", "()Z", ref global::java.sql.SQLInput_._readBoolean24990);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble24991;
		double java.sql.SQLInput.readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.sql.SQLInput_.staticClass, "readDouble", "()D", ref global::java.sql.SQLInput_._readDouble24991);
		}
		internal static global::MonoJavaBridge.MethodId _readString24992;
		global::java.lang.String java.sql.SQLInput.readString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.SQLInput_.staticClass, "readString", "()Ljava/lang/String;", ref global::java.sql.SQLInput_._readString24992) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readArray24993;
		global::java.sql.Array java.sql.SQLInput.readArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Array>(this, global::java.sql.SQLInput_.staticClass, "readArray", "()Ljava/sql/Array;", ref global::java.sql.SQLInput_._readArray24993) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _wasNull24994;
		bool java.sql.SQLInput.wasNull()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.SQLInput_.staticClass, "wasNull", "()Z", ref global::java.sql.SQLInput_._wasNull24994);
		}
		internal static global::MonoJavaBridge.MethodId _readBigDecimal24995;
		global::java.math.BigDecimal java.sql.SQLInput.readBigDecimal()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readBigDecimal", "()Ljava/math/BigDecimal;", ref global::java.sql.SQLInput_._readBigDecimal24995) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _readDate24996;
		global::java.sql.Date java.sql.SQLInput.readDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readDate", "()Ljava/sql/Date;", ref global::java.sql.SQLInput_._readDate24996) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _readTime24997;
		global::java.sql.Time java.sql.SQLInput.readTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readTime", "()Ljava/sql/Time;", ref global::java.sql.SQLInput_._readTime24997) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _readTimestamp24998;
		global::java.sql.Timestamp java.sql.SQLInput.readTimestamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readTimestamp", "()Ljava/sql/Timestamp;", ref global::java.sql.SQLInput_._readTimestamp24998) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _readCharacterStream24999;
		global::java.io.Reader java.sql.SQLInput.readCharacterStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readCharacterStream", "()Ljava/io/Reader;", ref global::java.sql.SQLInput_._readCharacterStream24999) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _readAsciiStream25000;
		global::java.io.InputStream java.sql.SQLInput.readAsciiStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readAsciiStream", "()Ljava/io/InputStream;", ref global::java.sql.SQLInput_._readAsciiStream25000) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readBinaryStream25001;
		global::java.io.InputStream java.sql.SQLInput.readBinaryStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readBinaryStream", "()Ljava/io/InputStream;", ref global::java.sql.SQLInput_._readBinaryStream25001) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readRef25002;
		global::java.sql.Ref java.sql.SQLInput.readRef()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Ref>(this, global::java.sql.SQLInput_.staticClass, "readRef", "()Ljava/sql/Ref;", ref global::java.sql.SQLInput_._readRef25002) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _readBlob25003;
		global::java.sql.Blob java.sql.SQLInput.readBlob()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Blob>(this, global::java.sql.SQLInput_.staticClass, "readBlob", "()Ljava/sql/Blob;", ref global::java.sql.SQLInput_._readBlob25003) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _readClob25004;
		global::java.sql.Clob java.sql.SQLInput.readClob()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Clob>(this, global::java.sql.SQLInput_.staticClass, "readClob", "()Ljava/sql/Clob;", ref global::java.sql.SQLInput_._readClob25004) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _readURL25005;
		global::java.net.URL java.sql.SQLInput.readURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.sql.SQLInput_.staticClass, "readURL", "()Ljava/net/URL;", ref global::java.sql.SQLInput_._readURL25005) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _readNString25006;
		global::java.lang.String java.sql.SQLInput.readNString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.SQLInput_.staticClass, "readNString", "()Ljava/lang/String;", ref global::java.sql.SQLInput_._readNString25006) as java.lang.String;
		}
		static SQLInput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLInput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
